using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nationwide_Base.Sections
{
    public enum TobaccoType
    {
        Unknown = 0,
        Cigarettes = 1,
        Cigars = 2,
        Pipe = 4,
        [Description("Chewing Tobacco")]
        ChewingTobacco = 8,
        Snuff = 16,
        [Description("Smokeless Tobacco")]
        SmokelessTobacco = 32,
        [Description("Nicotine Gum")]
        NicotineGum = 64,
        [Description("Nicotine Patch")]
        NicotinePatch = 128,
        [Description("Other Nicotine")]
        OtherNicotine = 4096,
        [Description("Electronic Cigarette")]
        ElectronicCigarette = 4352,
        [Description("Betel Nut")]
        BetelNut = 4353,
        Cigarillo = 4354,
        Hashish = 4355,
        Marijuana = 4356,
        [Description("Hookah or Shisha")]
        HookahOrShisha = 4357,
        Vapes = 1003700900, //Not Acord standard 
        [Description("Any tobacco or nicotine product")]
        AnyTobacco = 2147483646,
        Other = 2147483647
    }
}
