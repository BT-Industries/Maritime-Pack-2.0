using System;
using UnityEngine;
using UnityEngine.UI;

namespace MaritimePackModules
{
	public class propulsionIntake :PartModule
	{

		[KSPField]
		public string ResourceName = "";

		[KSPField]
		public bool fun = false;

		void Update () {

			if (fun) {

				Debug.Log ("The part explodes because there is the value \"fun = true\"");
				part.explode ();

			}

			var resourceList = part.Resources.list;

			foreach (PartResource resource in resourceList) {

				if (resource.resourceName == ResourceName) {

					vessel.checkSplashed ();

					if (resource != null && vessel.Splashed) {

						resource.amount = resource.maxAmount;

					}

				}

			}

		}

	}
}

