using System.IO;
using static AntiTrouble_Defender.Login;

namespace AntiTrouble_Defender_Test
{
    public class MainWindowTest
    {
        [WpfFact]
        public void HashKodGeneralas_ShouldReturnCorrectHashForKnownFile()
        {
            Felhasznalo tesztFelhasznalo = new Felhasznalo
            {
                Felhasznalonev = "mand",
                Jelszo = "mand"
            };
            MainWindow mainWindow = new MainWindow(tesztFelhasznalo);
            string testFilePath = "testfile.txt";
            string testFileContent = "This is a test file.";
            string expectedHash = "3de8f8b0dc94b8c2230fab9ec0ba0506";

            File.WriteAllText(testFilePath, testFileContent);

            try
            {
                string actualHash = mainWindow.HashKodGeneralas(testFilePath);
                Assert.Equal(expectedHash, actualHash);
            }
            finally
            {
                if (File.Exists(testFilePath))
                {
                    File.Delete(testFilePath);
                }
            }
        }
    }
}