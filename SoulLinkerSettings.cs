using System.Windows.Forms;
using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace SoulLinker;

public class SoulLinkerSettings : ISettings
{
    //Mandatory setting to allow enabling/disabling your plugin
    public ToggleNode Enable { get; set; } = new ToggleNode(false);

    //Put all your settings here if you can.
    //There's a bunch of ready-made setting nodes,
    //nested menu support and even custom callbacks are supported.
    //If you want to override DrawSettings instead, you better have a very good reason.

    [Menu("Target name", "Name of the  Link target", 1)]
    public TextNode linkerLeaderName { get; set; } = new TextNode("");

    [Menu("Is Mercenary", "Is the target a mercenary?", 7)]
    public ToggleNode IsMercenary { get; set; } = new ToggleNode(false);

    [Menu("Max Distance", "Max distance to target to use Link skill.", 2)]
    public RangeNode<int> linkerMaxDistance { get; set; } = new RangeNode<int>(800, 50, 1500);
    
    [Menu("Skill name", "Name of the  Link skill", 3)]
    public TextNode linkerSkillName { get; set; } = new TextNode("SoulLink");
    
    [Menu("Buff name", "Name of the  Link skill buff on the source.", 4)]
    public TextNode linkerBuffName { get; set; } = new TextNode("soul_link_source");

    [Menu("Skill key", "Key to use Link skill.", 5)]
    public HotkeyNode linkerSkillKey { get; set; } = new HotkeyNode(Keys.Q);
    
    [Menu("Tick time", "Time between each plugin tick, in milliseconds.", 6)]
    public RangeNode<int> tickTime { get; set; } = new RangeNode<int>(750, 200, 5000);
    
    [Menu("Debug", "Print debug messages?", 7)]
    public ToggleNode Debug { get; set; } = new ToggleNode(false);

    [Menu("Recast time", "Time of the recast before the buff end", 8)]
    public RangeNode<int> RecastTime { get; set; } = new RangeNode<int>(0, 0, 10);

    [Menu("Disable in hideout", "Disable casting in hideout", 9)]
    public ToggleNode InHideout { get; set; } = new ToggleNode(false);
}
