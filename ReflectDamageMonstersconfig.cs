using Turbo.Plugins.Default;

namespace Turbo.Plugins.Stone
{
    public class ReflectDamageMonstersConfig: BasePlugin, ICustomizer
    {
        public ReflectDamageMonstersConfig()
        {
            Enabled = true;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
        }

        public void Customize()
        {
            Hud.RunOnPlugin<ReflectDamageMonstersPlugin>(plugin =>
            {
                plugin.RFoffset = -2.0f; // Customize ��GroundLabel offset 
                plugin.RFminimapoffsetx = -10.0f; // Customize ��Label minimap offset
                plugin.RFminimapoffsety = -10.0f; // Customize ��Label minimap offset
                plugin.RFminimapoffsetz = -10.0f; // Customize ��Label minimap offset
			});
         }
	}
}