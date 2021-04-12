# Document ILMerge Task For MSBuild

## 1. ILMerge:
     Là một package có sẵn mục đích đóng gói các file .dll thành một file .dll hoặc đóng gói tất cả các file trong ứng dụng thành một file .exe
## 2 Cách sử dụng:
    - Tạo một Class Library và Add references các Project cần đóng gói vào.
    - Cài đặt pakage ILMerge.MSBuild.Task và ilmerge bằng cách sử dụng câu các lệnh tại PM Console::
        -> Install-Package ILMerge.MSBuild.Task
        -> Install-Package ilmerge
    - Config cho ILMerge.MSBuild.Task nếu không config thì ILMerge sẽ tự tạo file .dll đóng gói các file trên references có phần Coppy local là True.
    - Ngoài ra có thể tự tạo một file config bằng cách add một file Json tại project với tên là ILMergeConfig.json (tên mặc định) và nội như bênh dưới:
        {
          "General": {
            "OutputFile": "C:\\Users\\ACER\\OneDrive - VNU-HCMUS\\Documents\\GitHub\\TestDllHoa\\ProjectC\\bin\\Debug\\ILMerge\\BundleDll.dll",
            "TargetPlatform": null,
            "KeyFile": null,
            "AlternativeILMergePath": null,
            "InputAssemblies": [
              "C:\\Users\\ACER\\OneDrive - VNU-HCMUS\\Documents\\GitHub\\TestDllHoa\\ProjectC\\bin\\Debug\\ProjectA.dll",
              "ProjectD.dll"
            ]
      },
          "Advanced": {
            "AllowDuplicateType": null,
            "AllowMultipleAssemblyLevelAttributes": false,
            "AllowWildCards": false,
            "AllowZeroPeKind": false,
            "AttributeFile": null,
            "Closed": false,
            "CopyAttributes": false,
            "DebugInfo": true,
            "DelaySign": false,
            "DeleteCopiesOverwriteTarget": false,
            "ExcludeFile": "",
            "FileAlignment": 512,
            "Internalize": false,
            "Log": false,
            "LogFile": null,
            "PublicKeyTokens": true,
            "SearchDirectories": [],
            "TargetKind": null,
            "UnionMerge": false,
            "Version": null,
            "XmlDocumentation": false
          }
    }
    **Note: 
        - OutputFile: là đường dẫn đến nơi xuất file và BundleDll.dll là tên. 
        - KeyFile: là có đặt key cho file đóng gói không vd như đóng gói ra file .exe cần add 1 key.
        - InputAssemblies: là đường dẫn đến các dll cần được đóng gói.
        - Các phần còn lại là cấu hình default của ILMerge vd như trong quá trình bundle file dll cần ghi lại error log thì sang phần advance config Log và LogFile.
    - Sau khi config và cài đặt các Package trên thì buld project, ILMerge sẽ tạo ta file .dll bundle các file đã add trong config. Thường là sẽ tạo ở file bin/debug/ILMerge
## 3 Ảnh thư mục chứ file bundle
![Project To Merge Output](https://firebasestorage.googleapis.com/v0/b/practical-robot-295006.appspot.com/o/Backgroup%2FILMerge.PNG?alt=media&token=c6d3198b-e266-45d4-8a09-58be4360461d)
