using System.Threading.Tasks;
using System.Windows;
using FreeMax_File_Manager.Windows;
using GeneralClasses;
using Microsoft.AspNet.SignalR.Client;

namespace FreeMax_File_Manager {

    public static class FileWork {
        public static Window MainWindow;
        public static IHubProxy Proxy;

        public static void Rename(StringElement fileElement) {
            var name = fileElement.Name;
            if(name.StartsWith("(hidden)")) name = name.Substring(8, name.Length - 8);
            if(fileElement.IsDir) name = name.Substring(2, name.Length - 4);
            var aw = new AdditionalWindow {
                                              MyTitle = "��������������.",
                                              Text = $"������� ����� ��� ��� {name}.",
                                              Owner = MainWindow,
                                              VisibleButtons = (int) Buttons.BtnOk|(int) Buttons.BtnCancel,
                                              Rename = true
                                          };

            aw.ShowDialog();

            if(aw.Result == Results.Bad) return;

            if(fileElement.IsDir) {
                var directory =
                    Task.Run(async () => await Proxy.Invoke<string>("GetParent", fileElement.FullPath))
                        .GetAwaiter()
                        .GetResult();
                if(directory == "null") return;

                if(
                    Task.Run(async () => await Proxy.Invoke<bool>("IsDirectoryExist", directory + '\\' + aw.NewName))
                        .GetAwaiter()
                        .GetResult()) {
                    var aw1 = new AdditionalWindow {
                                                       MyTitle = "����������� ��������.",
                                                       Text =
                                                           $"����� {aw.NewName} ����������. ������ ��������� �������?",
                                                       Owner = MainWindow,
                                                       VisibleButtons = (int) Buttons.BtnOk|(int) Buttons.BtnCancel
                                                   };
                    aw1.ShowDialog();
                    if(aw1.Result == Results.Bad) return;
                }
                Task.Run(
                    async () =>
                    await Proxy.Invoke("MoveDirectory", fileElement.FullPath, directory + '\\' + aw.NewName))
                    .GetAwaiter()
                    .GetResult();
            }
            else {
                var fileInfo = Task.Run(async () => await Proxy.Invoke<string>("GetDirectoryOfFile", fileElement.FullPath))
                    .GetAwaiter()
                    .GetResult();
                if(fileInfo == "null") return;
                if(Task.Run(async () => await Proxy.Invoke<bool>("IsFileExist", fileInfo + '\\' + aw.NewName))
                       .GetAwaiter()
                       .GetResult()) {
                    var aw1 = new AdditionalWindow {
                                                       MyTitle = "����������� ��������.",
                                                       Text = $"���� {aw.NewName} ����������. ������ � ��������?",
                                                       Owner = MainWindow,
                                                       VisibleButtons = (int) Buttons.BtnOk|(int) Buttons.BtnCancel
                                                   };
                    aw1.ShowDialog();
                    if(aw1.Result == Results.Bad) return;
                    Task.Run(async () => await Proxy.Invoke("DeleteFile", fileInfo + '\\' + aw.NewName)).GetAwaiter().GetResult();
                }
                Task.Run(async () => await Proxy.Invoke("MoveFile", fileElement.FullPath, fileInfo + '\\' + aw.NewName)).GetAwaiter().GetResult();
            }
        }

        public static void CreateFile(StringElement fileElement) {
            var aw = new AdditionalWindow {
                                              MyTitle = "�������� �����.",
                                              Text = "������� ��� �����(� �����������)!",
                                              Owner = MainWindow,
                                              VisibleButtons = (int) Buttons.BtnOk|(int) Buttons.BtnCancel,
                                              ElemName = new StringElement(fileElement.FullPath)
                                          };
            aw.ShowDialog();
            if(aw.Result == Results.Bad) return;

            if(
                Task.Run(async () => await Proxy.Invoke<bool>("IsFileExist", aw.NewElem.FullPath))
                    .GetAwaiter()
                    .GetResult()) {
                var aw1 = new AdditionalWindow {
                                                   MyTitle = "����������� ��������.",
                                                   Text = $"���� {aw.Drive.Name} ����������. ������ �������� ���?",
                                                   Owner = MainWindow,
                                                   VisibleButtons = (int) Buttons.BtnYes|(int) Buttons.BtnNo
                                               };
                aw1.ShowDialog();
                if(aw1.Result == Results.Bad) return;
                Task.Run(async () => await Proxy.Invoke("DeleteFile", aw.NewElem.FullPath)).GetAwaiter().GetResult();
            }

            Task.Run(async () => await Proxy.Invoke("CreateFile", aw.NewElem.FullPath)).GetAwaiter().GetResult();
        }

        public static void CreateFolder(StringElement fileElement) {
            var aw = new AdditionalWindow {
                                              MyTitle = "�������� �����.",
                                              Text = "������� ��� �����!",
                                              Owner = MainWindow,
                                              VisibleButtons = (int) Buttons.BtnOk|(int) Buttons.BtnCancel,
                                              ElemName = new StringElement(fileElement.FullPath)
                                          };
            aw.ShowDialog();
            if(aw.Result == Results.Bad) return;

            if(
                Task.Run(async () => await Proxy.Invoke<bool>("IsDirectoryExist", aw.Drive.FullPath))
                    .GetAwaiter()
                    .GetResult()) {
                var aw1 = new AdditionalWindow {
                                                   MyTitle = "����������� ��������.",
                                                   Text = $"����� {aw.Drive.Name} ����������. ������ �������� �?",
                                                   Owner = MainWindow,
                                                   VisibleButtons = (int) Buttons.BtnYes|(int) Buttons.BtnNo
                                               };
                aw1.ShowDialog();
                if(aw.Result == Results.Bad) return;
                Task.Run(async () => await Proxy.Invoke("DeleteDirectiry", aw.Drive.FullPath)).GetAwaiter().GetResult();
            }

            Task.Run(async () => await Proxy.Invoke("CreateDirectory", aw.Drive.FullPath)).GetAwaiter().GetResult();
        }

        public static void DeleteElements(StringElement[] items) {
            if(items.Length == 0) return;

            var aw = new AdditionalWindow {
                                              Owner = MainWindow,
                                              Text = $"�� �������, ��� ������ ������� {items.Length} �������(-�,-��)?",
                                              MyTitle = "����������� ��������.",
                                              VisibleButtons = (int) (Buttons.BtnYes|Buttons.BtnNo)
                                          };
            aw.ShowDialog();

            if(aw.Result == Results.Bad) return;

            Delete(items);
        }

        private static void Delete(StringElement[] items) {
            foreach(var item in items) {
                Task.Run(async () => await Proxy.Invoke(item.IsDir?"DeleteDirectory": "DeleteFile", item.FullPath)).GetAwaiter().GetResult();
            }
        }

        public static void CopyElements(StringElement[] items, StringElement destination) {
            if(items.Length == 0) return;

            var aw = new AdditionalWindow {
                                              Owner = MainWindow,
                                              Text =
                                                  $"�� �������, ��� ������ ����������� {items.Length} �������(-�,-��)?",
                                              MyTitle = "����������� ��������.",
                                              VisibleButtons = (int) Buttons.BtnYes|(int) Buttons.BtnNo
                                          };
            aw.ShowDialog();
            if(aw.Result == Results.Bad) return;

            foreach(var elem in items) {
                Copy(elem, destination);
            }
        }

        private static void Copy(StringElement item, StringElement destination) {
            var name = item.Name;
            if(item.Name.StartsWith("(hidden)")) name = item.Name.Substring(8, item.Name.Length - 8);
            if(item.IsDir) {
                var dir = item.FullPath;
                name = item.Name.Substring(2, item.Name.Length - 4);

                var dest = destination.FullPath + '\\' + name;
                if(
                    Task.Run(
                        async () =>
                        await Proxy.Invoke<bool>("IsDirectoryExist", dest))
                        .GetAwaiter()
                        .GetResult()) {
                    var aw = new AdditionalWindow {
                                                      MyTitle = "����������� ��������.",
                                                      Text = $"����� {dest} ����������. ������ ��������� �������?",
                                                      VisibleButtons = (int) Buttons.BtnYes|(int) Buttons.BtnNo,
                                                      Owner = MainWindow
                                                  };
                    aw.ShowDialog();
                    if(aw.Result == Results.Bad) return;
                }
                else
                    Task.Run(async () => await Proxy.Invoke("CreateDirectory", dest))
                        .GetAwaiter()
                        .GetResult();
                Task.Run(async () => await Proxy.Invoke("CopyDirectory", dir, dest))
                    .GetAwaiter()
                    .GetResult();
            }
            else {
                if(Task.Run(
                    async () =>
                    await Proxy.Invoke<bool>("IsFileExist", destination.FullPath + '\\' + name))
                       .GetAwaiter()
                       .GetResult()) {
                    var aw = new AdditionalWindow {
                                                      MyTitle = "����������� ��������.",
                                                      Text = $"���� {name} ����������. ������ ��������� ���?",
                                                      VisibleButtons = (int) Buttons.BtnYes|(int) Buttons.BtnNo,
                                                      Owner = MainWindow
                                                  };
                    aw.ShowDialog();
                    if(aw.Result == Results.Bad) return;
                }
                Task.Run(async () => await Proxy.Invoke("CopyFile", item.FullPath, destination.FullPath + '\\' + name))
                    .GetAwaiter()
                    .GetResult();
            }
        }

        public static void MoveElements(StringElement[] items, StringElement destination) {
            //TODO ������ ���������� ����� ����� ������
            if(items.Length == 0) return;

            var aw = new AdditionalWindow {
                                              Owner = MainWindow,
                                              Text =
                                                  $"�� �������, ��� ������ ����������� {items.Length} �������(-�,-��)?",
                                              MyTitle = "����������� ��������.",
                                              VisibleButtons = (int) Buttons.BtnYes|(int) Buttons.BtnNo
                                          };
            aw.ShowDialog();

            if(aw.Result == Results.Bad) return;

            foreach(var item in items) {
                var name = item.Name;
                if(name.StartsWith("(hidden)")) name = name.Substring(8, name.Length - 8);
                if(item.IsDir) {
                    name = name.Substring(2, name.Length - 4);
                    if(
                        Task.Run(
                            async () => await Proxy.Invoke<bool>("IsDirectoryExist", destination.FullPath + '\\' + name))
                            .GetAwaiter()
                            .GetResult()) {
                        aw = new AdditionalWindow {
                                                      MyTitle = "����������� ��������.",
                                                      Text = $"����� {name} ����������. ������ ��������� �������?",
                                                      VisibleButtons = (int) Buttons.BtnYes|(int) Buttons.BtnNo,
                                                      Owner = MainWindow
                                                  };
                        aw.ShowDialog();
                        if(aw.Result == Results.Bad) return;
                    }
                    Task.Run(
                        async () =>
                        await Proxy.Invoke("MoveDirectory", item.FullPath, destination.FullPath + '\\' + name))
                        .GetAwaiter()
                        .GetResult();
                }
                else {
                    if(Task.Run(async () => await Proxy.Invoke<bool>("IsFileExist", destination.FullPath + '\\' + name))
                           .GetAwaiter()
                           .GetResult()) {
                        aw = new AdditionalWindow {
                                                      MyTitle = "����������� ��������.",
                                                      Text = $"���� {name} ����������. ������ �������� ���?",
                                                      VisibleButtons = (int) Buttons.BtnYes|(int) Buttons.BtnNo,
                                                      Owner = MainWindow
                                                  };
                        aw.ShowDialog();
                        if(aw.Result == Results.Bad) return;
                        Task.Run(async () => await Proxy.Invoke("DeleteFile", destination.FullPath + '\\' + name))
                            .GetAwaiter()
                            .GetResult();
                    }
                    Task.Run(
                        async () => await Proxy.Invoke("MoveFile", item.FullPath, destination.FullPath + '\\' + name))
                        .GetAwaiter()
                        .GetResult();
                }
            }
        }
    }
}
