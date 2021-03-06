using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Condition_bt_WrapperAI_Hero_HeroLowAI_node553 : Condition
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			ObjBehaviMode curBehavior = ((ObjAgent)pAgent).GetCurBehavior();
			ObjBehaviMode objBehaviMode = ObjBehaviMode.State_Idle;
			return (curBehavior == objBehaviMode) ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}
}
