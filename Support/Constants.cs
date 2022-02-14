using System.Reflection;

namespace TSI.FourSeries.FirstBoot
{
    public class Constants
    {

        public const string FileNotFoundCreatingNewFileMessage = "File not found @ {0}";
        public const string StaticFileContentsNoticeMessage = "FileContents: {0}";

        public const string DefaultFileContents = "{\"bootcount\":0}";

        public const string NothingToDeserializeMessage = "Nothing to deserialize";
        public const string ErrorConvertingFileContentsMessage = "Error Converting File contents to DisplayPresetListObject. FileContents: {0} | Error Message:  {1}";
        public const string ErrorWritingJsonToFile = "UpdateJSON - Exception writing to file: {0}";

        public const string JsonUpdateMessage = "JSON: {0}";


        public const string FileNotFoundMessage = "FileOperations.ReadFile() | Error: File Not Found!";
        public const string WriteFilePayloadReport = "FileOperations.WriteFile() | Message: payload written to file: {0}";
        public const string WriteFileExceptionStackTrace = "FileOperations.WriteFile() | Exception: {0}";

        public const string GetPresetListFromFileExceptionStackTrace = "GetPresetListFromFile Exception: {0}";
        public const string InitializeExceptionMessage = "FirstBoot.Initialize() ;0 | {0}";
        public const string OverwritePresetExceptionStackTrace = "OverwritePreset Exception: {0}";
        

    }
}