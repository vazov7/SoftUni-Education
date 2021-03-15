﻿using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            ILayout simpleLayout = new SimpleLayout();
            //IAppender consoleAppender =
            //new ConsoleAppender(simpleLayout);
            //ILogger logger = new Logger(consoleAppender);

            //logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            //logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");
            Console.WriteLine(simpleLayout.Template, 2, 3, 4);
        }
    }
}
