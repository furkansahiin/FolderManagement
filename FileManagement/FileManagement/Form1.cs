using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sourceText.Text = dialog.SelectedPath;
            }
            else
            {
                sourceText.Text = null;
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                targetText.Text = dialog.SelectedPath;
            }
            else
            {
                targetText.Text = null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(sourceText.Text.Trim() == "" || targetText.Text.Trim()=="")
            {
                // Dosya Yolları Boş
                // File Paths are Empty
                MessageBox.Show("Dosya yollarını belirleyiniz...");
                myloggertxt("Hata", "Mesajı", false, "Dosya Yolları Boş");
            }
            else if (!Directory.Exists(sourceText.Text))
            {
                // Verilen Kaynak Dosya Yolu Bulunamadı
                // Given Source File Path Not Found
                MessageBox.Show("Girilen Kaynak Dosya Yolu Bulunamadı.");
                myloggertxt("Hata", "Mesajı", false, "Girilen Kaynak Dosya Yolu Bulunamadı..");
            }

            else
            {
                myloggertxt("Bilgilendirme", "Mesajı", true, "İşlem Başlatılıyor...");

                if (!Directory.Exists(targetText.Text))
                {
                    DirectoryInfo di = Directory.CreateDirectory(targetText.Text);
                }
                int compressionlevel = zipLevel.SelectedIndex;
                string sourcePath = sourceText.Text;
                string targetPath = targetText.Text;

                string[] subdirectories = Directory.GetDirectories(sourcePath);
                string filePathName = new DirectoryInfo(sourceText.Text).Name;
                string zipFilePathName = filePathName + ".zip";
                if (changeSave.Checked)
                {
                    string sessionanadizin = sourceText.Text;
                    string sessiontargetpath = targetText.Text;
                    bool isYenidenAdlandir = rename.Checked;
                    bool isAltDizin = subdirectorieszipped.Checked;
                    SaveSettings(sessionanadizin, sessiontargetpath, isYenidenAdlandir, isAltDizin);
                }

                if (subdirectorieszipped.Checked)
                {
                    // alt dizinlerin de sıkıştırılması istendiğinde çalışacaktır.
                    // will work when subdirectories are also requested to be zipped.
                    string[] files = Directory.GetFiles(sourcePath);
                    if (files.Length == 0)
                    {
                        myloggertxt(zipFilePathName, sourcePath, true, "Ana Dizine Ait Dosya Yok.");
                    }
                    else
                    { 
                        try
                        {
                            if (File.Exists(zipFilePathName))
                            {
                                File.Delete(zipFilePathName);
                            }

                            files = Array.FindAll(files, s => !Directory.Exists(s));

                            using (ZipArchive zip = ZipFile.Open(zipFilePathName, ZipArchiveMode.Create))
                            {
                                foreach (string file in files)
                                {
                                    zip.CreateEntryFromFile(file, Path.GetFileName(file));
                                }
                            }

                            moveFile(zipFilePathName);
                            myloggertxt(zipFilePathName, sourcePath, true, "Ana Dizine Ait Dosyalar Ziplendi.");
                        }
                        catch
                        {
                            myloggertxt(zipFilePathName, sourcePath, false, "Ana Dizine Ait Dosyalar Alınamadı.");
                        }
                    }
                }

                if (compressionlevel == 2)
                {
                    myloggertxt("Bilgilendirme", "Mesajı", true, $"sıkıştırılmama düzeyi seçildi {compressionlevel}");

                    if (Directory.Exists(sourcePath))
                    {
                        // Mevcut değilse, hedef dizin oluştur
                        //Create target directory if it doesn't exist
                        if (!Directory.Exists(targetPath))
                        {
                            Directory.CreateDirectory(targetPath);
                        }

                        // Kaynak dizindeki tüm dosyaları ve alt dizinleri alın
                        // Get all files and subdirectories in source directory
                        var files = new DirectoryInfo(sourcePath).GetFileSystemInfos("*.*", SearchOption.AllDirectories);

                        //Dosyalar arasında dolaşın ve hedef klasöre taşıyın
                        //Loop through files and Move to destination folder
                        foreach (var file in files)
                        {
                            // Geçerli dosya/dizin için yeni hedef yolu oluşturun
                            //Construct new target path for current file/directory
                            var newTargetPath = targetPath + file.FullName.Replace(sourcePath, "");

                            if (file.Attributes.HasFlag(FileAttributes.Directory))
                            {
                                // Hedef yolda dizin oluştur
                                //Create directory in target path
                                Directory.CreateDirectory(newTargetPath);
                            }
                            else
                            {
                                // Dosyayı hedef yola kopyala
                                //Copy file to target path
                                File.Copy(file.FullName, newTargetPath, true);
                            }

                            // Dosya/dizinin hedef yola başarıyla kopyalanıp kopyalanmadığını kontrol edin
                            //Check if file/directory was successfully copied to target path
                            if (File.Exists(newTargetPath) || Directory.Exists(newTargetPath))
                            {
                                myloggertxt(file.FullName, newTargetPath, true, "Zipsiz taşıma işlemi başarılı oldu.");
                            }
                            else
                            {
                                myloggertxt(file.FullName, newTargetPath, false, "Zipsiz taşıma işlemi başarısız oldu.");
                            }
                        }
                    }
                }
                else
                {
                    myloggertxt("Bilgilendirme", "Mesajı", true, $"sıkıştırılma düzeyi seçildi {compressionlevel}");

                    foreach (string subdirectory in subdirectories)
                    {
                        string zipFilePath = Path.Combine(sourcePath, $"{Path.GetFileName(subdirectory)}.zip");
                        if (File.Exists(zipFilePath))
                        {
                            File.Delete(zipFilePath);
                        }

                        ZipFile.CreateFromDirectory(subdirectory, zipFilePath, (CompressionLevel)compressionlevel, true);

                        moveFile(zipFilePath);
                    }
                }

                // process completed
                MessageBox.Show("işlem tamamlandı.");
            }
        }
        private void moveFile(string zipFilePath)
        {
            string currentPath = targetText.Text;
            string fileName = Path.GetFileName(zipFilePath);
            string targetFilePath = Path.Combine(currentPath, fileName);
                            
            if (rename.Checked)
            {
                try
                {
                    // yeniden adlandırma seçildiğinde işlenecektir
                    //will be processed when rename is selected

                    // şuanki zamana göre yıl-ay-gün-saat-dakika-saniye olarak alıp dosuya isminin sonuna ekleme yapar 
                    // It takes the year-month-day-hour-minute-second according to the current time and adds it to the end of the file name.
                    string _fileName = Path.GetFileNameWithoutExtension(targetFilePath);
                    string extension = Path.GetExtension(targetFilePath);
                    string newFileName = _fileName + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + extension;
                    string newFilePath = Path.Combine(Path.GetDirectoryName(targetFilePath), newFileName);

                    try
                    {
                        File.Copy(zipFilePath, newFilePath, true);
                        if (File.Exists(newFilePath))
                        {
                            File.Delete(zipFilePath);
                            myloggertxt(zipFilePath, newFilePath, true, "yeniden adlandırma ve Dosya taşıma işlemi başarılı oldu.");
                        }
                        else
                        {
                            myloggertxt(zipFilePath, newFilePath, false, "yeniden adlandırma ve Dosya kopyalama hatası: Dosya kopyalanamadı.");
                        }
                    }
                    catch (IOException ex)
                    {
                        myloggertxt(zipFilePath, newFilePath, false, $"yeniden adlandırılma ve Dosya taşıma işlemi başarısız oldu. hata : {ex}");

                    }
                }
                catch (Exception ex)
                {
                    //hata durumunda günlüğe yazılacak
                    // will be written to the log in case of error
                    myloggertxt(zipFilePath, targetFilePath, false, $"yeniden adlandırılma başarısız. Hata : {ex.Message}");
                }
            }
            if (uzerineyaz.Checked)
            {
                try
                {
                    try
                    {
                        // kopyalama işlemi yapar taşma fonksiyonu çağrılmaz
                        // where the copy operation is performed, the overflow function is not called
                        File.Copy(zipFilePath, targetFilePath, true);
                        if (File.Exists(targetFilePath))
                        {
                            File.Delete(zipFilePath);
                            myloggertxt(zipFilePath, targetFilePath, true, "klasik işlem ve Dosya taşıma işlemi başarılı oldu.");
                        }
                        else
                        {
                            myloggertxt(zipFilePath, targetFilePath, false, "klasik işlem ve Dosya kopyalama hatası: Dosya kopyalanamadı.");
                        }
                    }
                    catch (IOException ex)
                    {
                        //hata durumunda günlüğe yazılacak
                        // will be written to the log in case of error
                        myloggertxt(zipFilePath, targetFilePath, false, $"klasik işlem ve Dosya taşıma işlemi başarısız oldu. hata : {ex}");

                    }
                }
                catch (Exception ex)
                {
                    //hata durumunda günlüğe yazılacak
                    // will be written to the log in case of error

                    myloggertxt(zipFilePath, targetFilePath, false, $"klasik işlem başarısız. Hata : {ex.Message}");
                }
            }
        }

        private void SaveSettings(string sessionanadizin, string sessiontargetpath, bool isYenidenAdlandir, bool isAltDizin)
        {
            // app.confige yazan fonksiyon eğer kabul edilirse işlem gerçekleşir ve yeniden başlatıldığında en son yüklenen değerleri alır.
            //If the function that writes app.confige is accepted, the process is executed and when it is restarted, it gets the last loaded values.
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["SourceFile"].Value = sessionanadizin;
            config.AppSettings.Settings["TargetFile"].Value = sessiontargetpath;
            config.AppSettings.Settings["IsYenidenAdlandir"].Value = isYenidenAdlandir.ToString();
            config.AppSettings.Settings["IsAltDizin"].Value = isAltDizin.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void myloggertxt(string zipFilePath, string targetFilePath, bool status, string errorMessage)
        {
            // loglama fonksiyonu çağırdığımız yerde logs klasörü yoksa oluşturur varsa içindeki logs dosyasını günceller.
            // If there is no logs folder where we call the logging function, it creates it and updates the logs file if it exists.

            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"\logs\");

            string logFilePath = Path.Combine(folderPath + "logs.txt");
            if (!File.Exists(logFilePath))
            {
                if (!File.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    File.Create(logFilePath).Dispose();
                }
                else
                {
                    File.Create(logFilePath).Dispose();
                }
            }

            // .txt dosyasına yazan kısım
            //The part that writes to the .txt file

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                string logMessage = $"{DateTime.Now}: SourceFile={zipFilePath}, TargetFile={targetFilePath}, Status={status}";
                if (status)
                {
                    logMessage += $", Mesaj = {errorMessage}";
                }
                else
                {
                    logMessage += $", Hata Mesajı = {errorMessage}";
                }
                writer.WriteLine(logMessage);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // burası form yüklenirken önceden kayıt edilen dosya var mı diye app.config dosyasını okuyor
            //This is where it reads the app.config file to see if there is a pre-registered file while the form is being loaded.

            zipLevel.SelectedIndex = 1;
            sourceText.Text = ConfigurationManager.AppSettings["SourceFile"];
            targetText.Text = ConfigurationManager.AppSettings["TargetFile"];

            bool isYenidenAdlandir = Convert.ToBoolean(ConfigurationManager.AppSettings["IsYenidenAdlandir"]);
            bool isAltDizin = Convert.ToBoolean(ConfigurationManager.AppSettings["IsAltDizin"] ); 

            rename.Checked = isYenidenAdlandir;
            subdirectorieszipped.Checked = isAltDizin;
        }
    }
}
