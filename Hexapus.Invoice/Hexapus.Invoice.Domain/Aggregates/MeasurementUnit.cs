using System.ComponentModel;

namespace Hexapus.Invoice.Domain.Aggregates
{
    public enum MeasurementUnit
    {
        [Description("cm")]
        CM = 1,
        [Description("m")]
        M,
        [Description("cm²")]
        CM2,
        [Description("m²")]
        M2,
        [Description("cm³")]
        CM3,
        [Description("m³")]
        M3,
        [Description("ml")]
        ML,
        [Description("l")]
        L,
        [Description("mg")]
        MG,
        [Description("kg")]
        KG,
        [Description("h")]
        HR,
        [Description("pcs")]
        PCS
    }
}
