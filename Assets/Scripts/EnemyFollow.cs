using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyFollow : MonoBehaviour

{

        public NavMeshAgent myEnemy;

        public Transform myPlayer;

        void Update()
        {

        SeguirJugador();

    }
        public void SeguirJugador()
        {
            myEnemy.SetDestination(myPlayer.position);
        
        }
   


}
