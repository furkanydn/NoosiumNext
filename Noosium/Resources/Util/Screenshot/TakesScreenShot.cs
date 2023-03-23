using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Noosium.WebDriver.Mock;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Noosium.Resources.Util.Screenshot;

public abstract class TakesScreenShot : BaseMockDriver
{
    public static string TakesScreenshot(string screenshotLocation)
    {
        //Directory path for saving screenshots
        //dirPath = @"..\..\..\" + scFolderName;
        var scFolderName = $"Screenshot {DateTime.Now:s}";
        var dirPath = $"{screenshotLocation}{scFolderName}";
        if (Directory.Exists(dirPath) == false)
        {
            var unused = Directory.CreateDirectory(dirPath);
        }

        // Screenshot path for returning the complete screenshot URL with its name
        var scPath = Path.Combine(Directory.GetCurrentDirectory(), $@"{dirPath}\");
        var testName = TestContext.CurrentContext.Test.Name.Replace('"', '\'').Replace(";", "-").Replace("/", "_");
        var testNameLenght = TestContext.CurrentContext.Test.Name.Replace('"', '\'').Replace(";", "-").Replace("/", "_")
            .Length;
        testName = testNameLenght switch
        {
            > 50 => $"{testName[..50]}...",
            _ => testName
        };
        
        //Take screenshot and save it specified location

        #region Take Screenshot and Save
        //The image of the page as a Base64-encoded string.
        var takesScreenshot = Driver as ITakesScreenshot ?? throw new InvalidOperationException($"The driver type '{Driver.GetType().FullName}' does not support taking screenshots.");
        var dummy = takesScreenshot.GetScreenshot();
        var fileP = $"{scPath}{testName}Screenshot_{DateTime.Now:s}.png";
        //screenshot.SaveAsFile(fileP,ScreenshotImageFormat.Png);
        #endregion

        #region Return Screen Shot Path
        
        var machineName = Environment.MachineName;
        var fileHostName = $"\\\\{machineName}{fileP}";
        var uri = new Uri(fileHostName);
        string returnPath = null!;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            returnPath = uri.AbsoluteUri.Replace("/","\\");
        Debug.Assert(returnPath != null, nameof(returnPath) + " != null");
        return returnPath;

        #endregion
    }
}