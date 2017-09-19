﻿//----------------------------------------------
// MVVM 4 uGUI
// © 2015 yedo-factory
//----------------------------------------------
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace M4u
{
    /// <summary>
    /// M4uBindingSingle. Bind single Path
    /// </summary>
	public class M4uBindingSingle : M4uBinding
	{
		public string Path;

		public override void Awake ()
		{
			base.Awake ();

			Paths = new string[] { Path };
			Values = new object[1];
		}
	}
}