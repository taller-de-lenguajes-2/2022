// See https://aka.ms/new-console-template for more information
using NLog;

Console.WriteLine("Hello, World!");


Logger logger = LogManager.GetCurrentClassLogger();

logger.Trace("Ejemplo de mensaje de trace ");    
logger.Debug("Ejemplo de mensaje debug ");        
logger.Info("Ejemplo de mensaje de información");        
logger.Warn("Ejemplo de mensaje de Warm");        
logger.Error("Ejemplo de mensaje de error");        
logger.Fatal("Ejemplo de mensaje de error Fatal");
