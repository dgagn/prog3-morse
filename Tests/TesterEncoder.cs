using Microsoft.VisualStudio.TestTools.UnitTesting;

using morse;

namespace Tests
{
    [TestClass]
    [TestCategory("DG")]
    public class TesterEncoder
    {
        [TestMethod]
        [DataRow("", "")]
        [DataRow("SOS", "...  ---  ...")]
        [DataRow("sos", "...  ---  ...")]
        [DataRow("Bonjour", "-...  ---  -.  .---  ---  ..-  .-.")]
        [DataRow("abcdefghijklmnopqrstuvwxyz", ".-  -...  -.-.  -..  .  ..-.  --.  ....  ..  .---  -.-  .-..  --  -.  ---  .--.  --.-  .-.  ...  -  ..-  ...-  .--  -..-  -.--  --..")]
        [DataRow("ABCDEFGHIJKLMNOPQRSTUVWXYZ", ".-  -...  -.-.  -..  .  ..-.  --.  ....  ..  .---  -.-  .-..  --  -.  ---  .--.  --.-  .-.  ...  -  ..-  ...-  .--  -..-  -.--  --..")]
        [DataRow("9876543210", "----.  ---..  --...  -....  .....  ....-  ...--  ..---  .----  -----")]
        [DataRow(".,?!-/@()", ".-.-.-  --..--  ..--..  -.-.--  -....-  -..-.  .--.-.  -.--.  -.--.-")]
        public void Version1(string texteNormal, string codeMorse)
        {
            Assert.AreEqual(codeMorse, Morse.Encoder(texteNormal));
        }

        [TestMethod]
        [DataRow("", "")]
        [DataRow("#", "?")]
        [DataRow("*+=&", "?  ?  ?  ?")]
        [DataRow("#S#O#S#", "?  ...  ?  ---  ?  ...  ?")]
        public void Version2(string texteNormal, string codeMorse)
        {
            Assert.AreEqual(codeMorse, Morse.Encoder(texteNormal));
        }

        [TestMethod]
        [DataRow("sos S O S sos", "...  ---  ...  |  ...  |  ---  |  ...  |  ...  ---  ...")]
        public void Version3(string texteNormal, string codeMorse)
        {
            Assert.AreEqual(codeMorse, Morse.Encoder(texteNormal));
        }

        [TestMethod]
        [DataRow("  sos   S  O S      sos     ", "...  ---  ...  |  ...  |  ---  |  ...  |  ...  ---  ...")]
        public void Version4(string texteNormal, string codeMorse)
        {
            Assert.AreEqual(codeMorse, Morse.Encoder(texteNormal));
        }

        [TestMethod]
        [DataRow("\t\tsos \t  S  O\tS   \t\t \t  sos\t   ", "...  ---  ...  |  ...  |  ---  |  ...  |  ...  ---  ...")]
        public void Version5(string texteNormal, string codeMorse)
        {
            Assert.AreEqual(codeMorse, Morse.Encoder(texteNormal));
        }

    }
}
