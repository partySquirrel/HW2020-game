using UnityEngine;

public class SimpleAnimationPlayer : MonoBehaviour
{
	Animator anim;

    void Start()
    {
		anim = GetComponent<Animator>();
    }

	public void PlayAnimation(string name)
	{
		if(!anim.GetCurrentAnimatorStateInfo(0).IsName(name))
			anim.Play(name);
	}
}
