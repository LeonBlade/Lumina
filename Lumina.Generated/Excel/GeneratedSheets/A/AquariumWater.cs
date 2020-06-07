using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AquariumWater", columnHash: 0x5eb59ccb )]
    public class AquariumWater : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public string Name;

        // col: 00 offset: 0004
        public byte unknown4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            unknown4 = parser.ReadOffset< byte >( 0x4 );


        }
    }
}