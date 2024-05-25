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
        [WpfFact]
        public void HashKodMegjeloles_InsertionSucceeded_ReturnsTrue()
        {
            Felhasznalo tesztFelhasznalo = new Felhasznalo
            {
                Felhasznalonev = "mand",
                Jelszo = "mand"
            };
            MainWindow mainWindow = new MainWindow(tesztFelhasznalo);
            var defenderDatabase = new DefenderDatabase();
            string hash = "some_hash";
            string fileName = "some_file_name";

            // Act
            bool result = mainWindow.HashKodMegjeloles(hash, fileName);

            // Assert
            Assert.True(result);
            Assert.True(defenderDatabase.InsertHashKod(hash, fileName));
        }

        [WpfFact]
        public void HashKodMegjeloles_InsertionFailed_ReturnsFalse()
        {
            Felhasznalo tesztFelhasznalo = new Felhasznalo
            {
                Felhasznalonev = "mand",
                Jelszo = "mand"
            };
            MainWindow mainWindow = new MainWindow(tesztFelhasznalo);
            var defenderDatabase = new DefenderDatabase();
            string hash = "some_hash";
            string fileName = "some_file_name";

            // Act
            bool result = mainWindow.HashKodMegjeloles(hash, fileName);

            // Assert
            Assert.False(result);
            Assert.False(defenderDatabase.InsertHashKod(hash, fileName));
        }

        [WpfFact]
        public void Logbejegyzes_InsertionSucceeded_ReturnsTrue()
        {
            Felhasznalo tesztFelhasznalo = new Felhasznalo
            {
                Felhasznalonev = "mand",
                Jelszo = "mand"
            };
            MainWindow mainWindow = new MainWindow(tesztFelhasznalo);
            DefenderDatabase defenderDatabase = new DefenderDatabase();
            int infectedFiles = 10;
            int cleanedFiles = 5;

            // Act
            bool result = mainWindow.Logbejegyzes(tesztFelhasznalo.Felhasznalonev, infectedFiles, cleanedFiles);

            // Assert
            Assert.True(result);
            Assert.True(defenderDatabase.InsertLogEntries(tesztFelhasznalo.Felhasznalonev, infectedFiles, cleanedFiles));
        }

        [WpfFact]
        public void Logbejegyzes_InsertionFailed_ReturnsFalse()
        {
            Felhasznalo tesztFelhasznalo = new Felhasznalo
            {
                Felhasznalonev = "mand",
                Jelszo = "mand"
            };
            MainWindow mainWindow = new MainWindow(tesztFelhasznalo);
            var defenderDatabase = new DefenderDatabase();
            int infectedFiles = 10;
            int cleanedFiles = 5;

            // Act
            bool result = mainWindow.Logbejegyzes(tesztFelhasznalo.Felhasznalonev, infectedFiles, cleanedFiles);

            // Assert
            Assert.False(result);
            Assert.False(defenderDatabase.InsertLogEntries(tesztFelhasznalo.Felhasznalonev, infectedFiles, cleanedFiles));
        }
    }
}
