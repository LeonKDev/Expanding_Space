using UnityEngine;
using System.Collections;

namespace Pathfinding {

	[UniqueComponent(tag = "ai.destination")]
	public class AIDestinationSetter : VersionedMonoBehaviour {
        public Transform target;
        private GameObject Target;
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
			Target = GameObject.FindWithTag("Player");
			if(Target == null)
            {
				Target = GameObject.Find("Player");
            }
			if (Target != null && ai != null) ai.destination = Target.transform.position;
		}

	}
}
