using UtilsLibrary.DAC;
namespace UtilsLibrary.Bussiness
{
    internal sealed class LoggerBusiness
    {
        internal void SaveLog(Log logToSave)
        {
            LoggerDac dac = new LoggerDac();
            var logs = dac.Get();
            logs.Add(logToSave);
            dac.Save(logs);
        }
    }
}