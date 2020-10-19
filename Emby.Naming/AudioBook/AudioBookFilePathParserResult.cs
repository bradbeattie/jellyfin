#nullable enable
#pragma warning disable CS1591

namespace Emby.Naming.AudioBook
{
    public struct AudioBookFilePathParserResult
    {
        public int? PartNumber { get; set; }

        public int? ChapterNumber { get; set; }

        public bool Success { get; set; }
    }
}
