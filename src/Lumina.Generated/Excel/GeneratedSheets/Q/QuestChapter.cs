using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestChapter", columnHash: 0x5edc18ea )]
    public class QuestChapter : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint Quest;

        // col: 01 offset: 0004
        public ushort Redo;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Quest = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            Redo = parser.ReadOffset< ushort >( 0x4 );


        }
    }
}