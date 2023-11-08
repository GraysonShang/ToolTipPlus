using GrapeCity.Forguncy.Commands;
using GrapeCity.Forguncy.Plugin;
using System;
using System.ComponentModel;

namespace ToolTipPlus
{
    [Icon("pack://application:,,,/ToolTipPlus;component/Resources/Icon.png")]
    [Designer("ToolTipPlus.Designer.ToolTipPlusCommandDesigner, ToolTipPlus")]
    public class ToolTipPlusCommand : Command
    {
        [DisplayName("命令属性")]
        [FormulaProperty]
        public object MyProperty { get; set; }

        public override string ToString()
        {
            return "文本框提示命令";
        }
    }
}
