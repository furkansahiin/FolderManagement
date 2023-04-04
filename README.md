# FolderManagement

# EN
The code first checks whether the source and target file paths are empty or not. If either of them is empty, it displays a message box with an error message and logs the error message using the "myloggertxt" method.

If the source file path is valid, it creates a directory with the target file path. It then checks whether the "subdirectorieszipped" checkbox is checked or not. If it is checked, it zips all the files in the source directory into a new zip file with the name of the source directory, moves the zip file to the target directory, and logs the success or failure of the operation using the "myloggertxt" method.

If the compression level is set to 2, it moves all the files and subdirectories from the source directory to the target directory without compressing them. If the compression level is not 2, it compresses each subdirectory in the source directory using the selected compression level and moves the compressed directory to the target directory. The progress and results of each operation are logged using the "myloggertxt" method.

# TR
Kod önce kaynak ve hedef dosya yollarının boş olup olmadığını kontrol eder. Bunlardan herhangi biri boşsa, hata mesajı içeren bir iletişim kutusu görüntüler ve hata mesajını "myloggertxt" yöntemini kullanarak kaydeder.

Kaynak dosya yolu geçerliyse, hedef dosya yoluyla bir dizin oluşturur. Ardından, "subdirectorieszipped" onay kutusu işaretlenmişse, kaynak dizindeki tüm dosyaları yeni bir zip dosyasına kaydeder, zip dosyasını hedef dizine taşır ve işlemin başarısı veya başarısızlığı "myloggertxt" yöntemini kullanarak kaydeder.

Sıkıştırma seviyesi 2 olarak ayarlandığında, kaynak dizindeki tüm dosya ve alt dizinleri sıkıştırmadan hedef dizine taşır. Sıkıştırma seviyesi 2 değilse, kaynak dizindeki her alt dizini seçilen sıkıştırma seviyesiyle sıkıştırır ve sıkıştırılmış dizini hedef dizine taşır. Her işlemin ilerlemesi ve sonuçları "myloggertxt" yöntemi kullanılarak kaydedilir.
