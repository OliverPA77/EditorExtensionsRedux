﻿using System;
using System.Xml.Serialization;
using UnityEngine;
using System.Collections.Generic;

namespace EditorExtensionsRedux
{
	[XmlRoot ("ConfigData")]
	public class ConfigData
	{
		[XmlElement ("FileVersion")]
		public string FileVersion { get; set; }

		[XmlElement ("KeyMap")]
		public KeyMaps KeyMap { get; set; }

		[XmlArray ("AngleSnapValues")]
		public List<float> AngleSnapValues { get; set; }

		[XmlElement ("MaxSymmetry")]
		public int MaxSymmetry { get; set; }

		// Fwiffo start
		[XmlElement ("RapidZoom")]
		public bool RapidZoom { get; set; }
    
		//[XmlElement("ZoomCycling")]
		//public bool ZoomCycling { get; set; }
    
		//[XmlArray("ZoomCycleDistances")]
		//public List<float> ZoomCycleDistances { get; set; }

		// Fwiffo end

		[XmlElement ("ShowDebugInfo")]
		public bool ShowDebugInfo { get; set; }

		/// <summary>
		/// Time, in seconds, that the on screen messages will display
		/// </summary>
		[XmlElement ("OnScreenMessageTime")]
		public float OnScreenMessageTime { get; set; }

		public ConfigData ()
		{
			this.KeyMap = new KeyMaps ();
		}
	}

	public class KeyMaps
	{
		[XmlElement ("ResetCamera")]
		public KeyCode ResetCamera { get; set; }

		[XmlElement ("ZoomSelected")]
		public KeyCode ZoomSelected { get; set; }

		[XmlElement ("AttachmentMode")]
		public KeyCode AttachmentMode { get; set; }

		[XmlElement ("PartClipping")]
		public KeyCode PartClipping { get; set; }

		[XmlElement ("VerticalSnap")]
		public KeyCode VerticalSnap { get; set; }

		[XmlElement ("HorizontalSnap")]
		public KeyCode HorizontalSnap { get; set; }

		[XmlElement ("CompoundPartAlign")]
		public KeyCode CompoundPartAlign { get; set; }

        [XmlElement("FineAdjustWindow")]
        public KeyCode FineAdjustWindow { get; set; }


		[XmlElement ("Up")]
		public KeyCode Up { get; set; }
		[XmlElement ("Down")]
		public KeyCode Down { get; set; }
		[XmlElement ("Left")]
		public KeyCode Left { get; set; }
		[XmlElement ("Right")]
		public KeyCode Right { get; set; }
		[XmlElement ("Forward")]
		public KeyCode Forward { get; set; }
		[XmlElement ("Back")]
		public KeyCode Back { get; set; }


	}
}

