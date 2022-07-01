using UnityEngine;
using System.Collections;

namespace Pathfinding {

	[UniqueComponent(tag = "ai.destination")]
	[HelpURL("http://arongranberg.com/astar/docs/class_pathfinding_1_1_a_i_destination_setter.php")]
	public class AIDestinationSetter : VersionedMonoBehaviour {
        public Transform target;
        public GameObject Target;
		IAstarAI ai;

        void Start()
        {
			Target = GameObject.FindWithTag("Player");

		}

        void OnEnable () {
			ai = GetComponent<IAstarAI>();

			if (ai != null) ai.onSearchPath += Update;
		}

		void OnDisable () {
			if (ai != null) ai.onSearchPath -= Update;
		}
		void Update () {
			if (Target != null && ai != null) ai.destination = Target.transform.position;
		}

	}
}
