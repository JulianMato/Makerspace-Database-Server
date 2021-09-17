﻿using System;
using System.Collections.Generic;
using Construct.Core.Server;
using Construct.Swipe.Controllers;
using Construct.User.Controllers;

namespace Construct.Combined
{
    public class Program
    {
        /// <summary>
        /// Runs the program.
        /// </summary>
        /// <param name="args">Arguments from the command line.</param>
        public static void Main(string[] args)
        {
            // Reference controller the types.
            // Something needs to be referenced or else the assemblies will not be included, resulting in the
            // controllers not being loaded. Only 1 per project/assembly is required.
            var controllers = new List<Type>()
            {
                // Construct.User reference
                typeof(UserController),
                // Construct.Swipe reference
                typeof(SwipeController),
            };
            
            // Start the app.
            ServerProgram.Run(args, "Combined");
        } 
    }
}