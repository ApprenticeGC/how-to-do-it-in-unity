# Overview

Using slider to control the spcific animation.

# Requirement

Using Unity 2021.1.x as minimum version as the project uses Visual Scripting.

# References

- [Play an animation from the animator at a specific FRAME using anim.Play();](https://answers.unity.com/questions/1321953/play-an-animation-from-the-animator-at-a-specific.html)
- [Jump to a specific frame in an animator](https://answers.unity.com/questions/1272641/jump-to-a-specific-frame-in-an-animator.html)

```cs
anim = GetComponent<Animator>();
anim.speed = 0f;
anim.Play("YOUR_ANIMATION_NAME_HERE",0,YOUR_TIME_INDEX_HERE);
```
