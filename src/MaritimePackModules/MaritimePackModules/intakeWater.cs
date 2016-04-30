using System;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace MaritimePackModules
{
	public class intakeWater : PartModule
	{

		bool running = false;
		bool draining = false;

		[KSPField]
		public string ResourceName = "";

		[KSPField]
		public float flowRate = 1.0f;

		void Update () {

			if (running) {

				status = "Open";
				draining = false;

				var resourceList = part.Resources.list;

				foreach (PartResource resource in resourceList) {

					if (resource.resourceName == ResourceName) {

						vessel.checkSplashed ();

						if (resource != null && vessel.Splashed) {

							resource.amount += flowRate * TimeWarp.deltaTime;
							if (resource.amount > resource.maxAmount)
								resource.amount = resource.maxAmount;

						}

					}

				}

			} else if (draining) {

				status = "Draining";
				running = false;

				var resourceList = part.Resources.list;

				foreach (PartResource resource in resourceList) {

					if (resource.resourceName == ResourceName) {

						if (resource != null) {

							resource.amount -= flowRate + 1 * TimeWarp.deltaTime;
							if (resource.amount < 0) {
								resource.amount = 0;
								draining = false;
							}

						}

					}

				}

			} else {

				status = "Closed";

			}

		}

		[KSPEvent(guiActive = true, guiName = "Toggle Intake")]
		public void onSwitch () {

			running = !running;

		}

		[KSPField(guiActive = true, guiName = "Intake Status")]
		public string status = "Closed";

		[KSPEvent(guiActive = true, guiName = "Toggle Drain")]
		public void onToggleDrain () {

			draining = !draining;
			if (draining)
				running = false;

		}

	}
}