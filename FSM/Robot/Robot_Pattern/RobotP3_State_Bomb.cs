using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotP3_State_Bomb : Base_Interface<Robot_Base>
{
    private string Phase3_StartEffect = "Phase3_StartEffect";
    private string Phase3_Bomb_Effect = "Phase3_Bomb_Effect";


    public void OnEnter(Robot_Base robot_p1)
    {
        robot_p1.StartCoroutine(Fire_Cannon(robot_p1));
    }

    public void OnUpdate(Robot_Base robot_p1)
    {
        robot_p1.robotAi.AnimationEndCheck();

    }

    public void OnExit(Robot_Base robot_p1)
    {

    }

    public void OnFixedUpdate(Robot_Base robot_p1)
    {

    }

    IEnumerator Fire_Cannon(Robot_Base robot_p1)
    {
        robot_p1.Animation_id = "bomb";
        robot_p1.robot_Animator.SetTrigger(robot_p1.Animation_id);
      //  yield return new WaitUntil(() => robot_p1.AnimationName && robot_p1.AnimationProgress >= 0.12f);
        yield return StaticCoroutine.WaitUntil(robot_p1.Animation_id, 0.12f, robot_p1.robot_Animator);
        CinemachineImpulse.Instance.CameraShake(3f);
        yield return StaticCoroutine.WaitUntil(robot_p1.Animation_id, 0.35f, robot_p1.robot_Animator);
      //  yield return new WaitUntil(() => robot_p1.AnimationName && robot_p1.AnimationProgress >= 0.35f);
        CinemachineImpulse.Instance.CameraShake(3f);
        // yield return new WaitUntil(() => robot_p1.AnimationName && robot_p1.AnimationProgress >= 0.57f);
        yield return StaticCoroutine.WaitUntil(robot_p1.Animation_id, 0.57f, robot_p1.robot_Animator);
        CinemachineImpulse.Instance.CameraShake(3f);
        GameObject FireExplosion = ObjectPoolingManager.Instance.GetObject(Phase3_StartEffect, robot_p1.RobotP3.MissilePos[4]);
        GameObject FireExplosion2 = ObjectPoolingManager.Instance.GetObject(Phase3_StartEffect, robot_p1.RobotP3.MissilePos[5]);
        GameObject bomb1 = ObjectPoolingManager.Instance.GetObject_Noparent(Phase3_Bomb_Effect, robot_p1.RobotP3.BombRespawnPos[0]);
        //  yield return new WaitUntil(() => robot_p1.AnimationName && robot_p1.AnimationProgress >= 0.62f);
        yield return StaticCoroutine.WaitUntil(robot_p1.Animation_id, 0.62f, robot_p1.robot_Animator);
        CinemachineImpulse.Instance.CameraShake(3f);
        GameObject bomb2= ObjectPoolingManager.Instance.GetObject_Noparent(Phase3_Bomb_Effect, robot_p1.RobotP3.BombRespawnPos[1]);
        //  yield return new WaitUntil(() => robot_p1.AnimationName && robot_p1.AnimationProgress >= 0.67f);
        yield return StaticCoroutine.WaitUntil(robot_p1.Animation_id, 0.67f, robot_p1.robot_Animator);
        CinemachineImpulse.Instance.CameraShake(3f);
        GameObject bomb3 = ObjectPoolingManager.Instance.GetObject_Noparent(Phase3_Bomb_Effect, robot_p1.RobotP3.BombRespawnPos[2]);
        //   yield return new WaitUntil(() => robot_p1.AnimationName && robot_p1.AnimationProgress >= 0.72f);
        yield return StaticCoroutine.WaitUntil(robot_p1.Animation_id, 0.72f, robot_p1.robot_Animator);
    }
}