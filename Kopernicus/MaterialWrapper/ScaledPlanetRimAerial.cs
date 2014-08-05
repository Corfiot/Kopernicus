// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

namespace Kopernicus
{
    namespace MaterialWrapper
    {
        public class ScaledPlanetRimAerial : Material
        {
            // Internal property ID tracking object
            protected class Properties
            {
                // Return the shader for this wrapper
                private const string shaderName = "Terrain/Scaled Planet (RimAerial)";
                public static Shader shader
                {
                    get { return Shader.Find (shaderName); }
                }

                // Main Color, default = (1,1,1,1)
                private const string colorKey = "_Color";
                public int colorID { get; private set; }

                // Specular Color, default = (0.5,0.5,0.5,1)
                private const string specColorKey = "_SpecColor";
                public int specColorID { get; private set; }

                // Shininess, default = 0.078125
                private const string shininessKey = "_Shininess";
                public int shininessID { get; private set; }

                // Base (RGB) Gloss (A), default = "white" {}
                private const string mainTexKey = "_MainTex";
                public int mainTexID { get; private set; }

                // Normalmap, default = "bump" {}
                private const string bumpMapKey = "_BumpMap";
                public int bumpMapID { get; private set; }

                // Opacity, default = 1
                private const string opacityKey = "_Opacity";
                public int opacityID { get; private set; }

                // Rim Power, default = 3
                private const string rimPowerKey = "_rimPower";
                public int rimPowerID { get; private set; }

                // Rim Blend, default = 1
                private const string rimBlendKey = "_rimBlend";
                public int rimBlendID { get; private set; }

                // RimColorRamp, default = "white" {}
                private const string rimColorRampKey = "_rimColorRamp";
                public int rimColorRampID { get; private set; }

                // LightDirection, default = (1,0,0,0)
                private const string localLightDirectionKey = "_localLightDirection";
                public int localLightDirectionID { get; private set; }

                // Resource Map (RGB), default = "black" {}
                private const string resourceMapKey = "_ResourceMap";
                public int resourceMapID { get; private set; }

                // Singleton instance
                private static Properties singleton = null;
                public static Properties Instance
                {
                    get
                    {
                        // Construct the singleton if it does not exist
                        if(singleton == null)
                            singleton = new Properties();
            
                        return singleton;
                    }
                }

                private Properties()
                {
                    colorID = Shader.PropertyToID(colorKey);
                    specColorID = Shader.PropertyToID(specColorKey);
                    shininessID = Shader.PropertyToID(shininessKey);
                    mainTexID = Shader.PropertyToID(mainTexKey);
                    bumpMapID = Shader.PropertyToID(bumpMapKey);
                    opacityID = Shader.PropertyToID(opacityKey);
                    rimPowerID = Shader.PropertyToID(rimPowerKey);
                    rimBlendID = Shader.PropertyToID(rimBlendKey);
                    rimColorRampID = Shader.PropertyToID(rimColorRampKey);
                    localLightDirectionID = Shader.PropertyToID(localLightDirectionKey);
                    resourceMapID = Shader.PropertyToID(resourceMapKey);
                }
            }

            // Specular Color, default = (0.5,0.5,0.5,1)
            public Color specColor
            {
                get { return GetColor (Properties.Instance.specColorID); }
                set { SetColor (Properties.Instance.specColorID, value); }
            }

            // Shininess, default = 0.078125
            public float shininess
            {
                get { return GetFloat (Properties.Instance.shininessID); }
                set { SetFloat (Properties.Instance.shininessID, Mathf.Clamp(value,0.03f,1f)); }
            }

            // Base (RGB) Gloss (A), default = "white" {}
            public Texture2D mainTex
            {
                get { return GetTexture (Properties.Instance.mainTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.mainTexID, value); }
            }

            // Normalmap, default = "bump" {}
            public Texture2D bumpMap
            {
                get { return GetTexture (Properties.Instance.bumpMapID) as Texture2D; }
                set { SetTexture (Properties.Instance.bumpMapID, value); }
            }

            // Opacity, default = 1
            public float opacity
            {
                get { return GetFloat (Properties.Instance.opacityID); }
                set { SetFloat (Properties.Instance.opacityID, Mathf.Clamp(value,0f,1f)); }
            }

            // Rim Power, default = 3
            public float rimPower
            {
                get { return GetFloat (Properties.Instance.rimPowerID); }
                set { SetFloat (Properties.Instance.rimPowerID, value); }
            }

            // Rim Blend, default = 1
            public float rimBlend
            {
                get { return GetFloat (Properties.Instance.rimBlendID); }
                set { SetFloat (Properties.Instance.rimBlendID, value); }
            }

            // RimColorRamp, default = "white" {}
            public Texture2D rimColorRamp
            {
                get { return GetTexture (Properties.Instance.rimColorRampID) as Texture2D; }
                set { SetTexture (Properties.Instance.rimColorRampID, value); }
            }

            // LightDirection, default = (1,0,0,0)
            public Vector4 localLightDirection
            {
                get { return GetVector (Properties.Instance.localLightDirectionID); }
                set { SetVector (Properties.Instance.localLightDirectionID, value); }
            }

            // Resource Map (RGB), default = "black" {}
            public Texture2D resourceMap
            {
                get { return GetTexture (Properties.Instance.resourceMapID) as Texture2D; }
                set { SetTexture (Properties.Instance.resourceMapID, value); }
            }

            public ScaledPlanetRimAerial() : base(Properties.shader)
            {
            }

            public ScaledPlanetRimAerial(string contents) : base(contents)
            {
                base.shader = Properties.shader;
            }

            public ScaledPlanetRimAerial(Material material) : base(material)
            {
                // Throw exception if this material was not the proper material
                if (material.shader.name != Properties.shader.name)
                    throw new InvalidOperationException("Type Mismatch: Terrain/Scaled Planet (RimAerial) shader required");
            }

        }
    }
}
