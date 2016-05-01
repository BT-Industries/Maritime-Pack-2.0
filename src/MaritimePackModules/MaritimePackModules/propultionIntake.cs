using System;
using UnityEngine;
using UnityEngine.UI;

namespace MaritimePackModules
{
	public class propultionIntake :PartModule
	{

		[KSPField]
		public string ResourceName = "";

		void Update () {

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

