﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Run : StateMachineBehaviour
{

	//Variables to define the boss's speed and attack range
	
	public float speed = 2.5f;
	public float attackRange = 3f;

	Transform player;
	Rigidbody2D rb;
	BossRotate boss;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
		player = GameObject.FindGameObjectWithTag("Player").transform;
		rb = animator.GetComponent<Rigidbody2D>();
		boss = animator.GetComponent<BossRotate>();

	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		//This makes the boss always rotate towards the player no matter where they are
		
		boss.LookAtPlayer();

		Vector2 target = new Vector2(player.position.x, rb.position.y);
		Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
		rb.MovePosition(newPos);

		if (Vector2.Distance(player.position, rb.position) <= attackRange)
		{
			animator.SetTrigger("Attack");
		}
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		//Ensures the boss doesn't permanently stay attacking, and goes back to its normal movement when the player is out of range
		animator.ResetTrigger("Attack");
	}
}
