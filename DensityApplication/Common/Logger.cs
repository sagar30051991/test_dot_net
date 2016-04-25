using System;
using System.IO;
using DensityApplication.Common;


namespace ClientUI.Common
{
  public class Logger
  {
    private int _ALL = 100;
    private int _INFO = 75;
    private int _ERROR = 50;
    private int _OFF = 0;

    private String logDirectory = System.Configuration.ConfigurationManager.AppSettings["logDirectory"].ToString();

    public Logger()
    {
    }

    public int ALL
    {
      get { return _ALL; }
    }
    public int ERROR
    {
      get { return _ERROR; }
    }
    public int INFO
    {
      get { return _INFO; }
    }
    public int OFF
    {
      get { return _OFF; }
    }
      public void append(String message, int level)
      {
          try
          {
              int logLevel = 100;
              String strLogLevel = System.Configuration.ConfigurationManager.AppSettings["logLevel"].ToString();
              //switch (strLogLevel)
              //{
              //    case "ALL":
              //        logLevel = _ALL;
              //        break;
              //    case "ERROR":
              //        logLevel = _ERROR;
              //        break;
              //    case "INFO":
              //        logLevel = _INFO;
              //        break;
              //    default:
              //        logLevel = _OFF;
              //        break;
              //}
              if (logLevel >= level)
              {
                  DateTime dt = DateTime.Now;
                  if (!Directory.Exists(logDirectory))
                  {
                      Directory.CreateDirectory(logDirectory);
                  }

                  String filePath = logDirectory + dt.ToString("yyyyMMdd") + ".log";
                  if (!File.Exists(filePath))
                  {
                      try
                      {
                          FileStream fs = File.Create(filePath);
                          fs.Close();
                      }
                      catch
                      {
                          throw new Exception("Unable to generate log file.");
                      }
                  }
                  try
                  {
                      StreamWriter sw = File.AppendText(filePath);
                      sw.WriteLine(dt.ToString("hh:mm:ss") + "|" + message);
                      sw.Flush();
                      sw.Close();
                  }
                  catch (Exception ex)
                  {
                      ErrorLogging.LogError(ex);
                  }
              }
          }
          catch ( Exception ex )
          {
              throw ex;
          }
      }
  
  
  }
}