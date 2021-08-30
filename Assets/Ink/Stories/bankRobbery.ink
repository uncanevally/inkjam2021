- Good morning #Game

* [Hello there, how's it going?] ->LineOnePt1
* [...] -->LineTwoPt1
* [Good morning!] -->LineTwoPt1

== LineOnePt1 ==
- I'm kinda agitated. #Game

* [Why?] -->CanWeTalk

== CanWeTalk ==
- Its... complicated... Can I talk to you about something? #Game

* [Who cares? It's a free country, I guess...]
* [I don't know.]
* [...] 

- I'm thinking about robbing a bank. #Game 
-->LetTheGameBegin

== BadEnding ==
- I didn't mean to boder you... I am sorry #Endgame #BankRobbed 
-->END

== GoodEnding ==
- Looks like we got into an agreement. It was nice to talk to you fella... see you soon #Endgame #BankNotRobbed
-->END

== UWillThinkSomething ==
- Sure I will... #Game
-->BadEnding

== WhatDoIDo ==
- Before you go, I want to ask you something. What do I do? #Game
* [<b>You'll think of something.</b>] -->UWillThinkSomething

== LetTheGameBegin == 
* [You're thinking about WHAT?] -->LineOnePt2Resp1
* [That's cool, do you have a plan?] -->LineOnePt3Resp1
* [And why would you do that?] -->LineOnePt2Resp2

== LineOnePt2Resp1 ==
- About robbing a bank. It's just one of those thoughts you have that you usually keep to yourself. I don't even know why I'm telling you this. I guess i just wanted to get it out of my chest, and you seemed like the right person to talk to. #Game

* [Is this some kind of a joke? I am not sure I wanna talk about it, please leave] -->BadEnding
* [I think everyone though about it some day... can't judge you. Do you have a plan?]-->LineOnePt3Resp1
* [That's creepy man, you shouldn't do this kinda stuff so...]-->LineOnePt3Resp2
* [Do you have a plan?]-->LineOnePt3Resp1

== LineOnePt3Resp1 ==
- It's all planned. I already got a gun, a mask, and a getaway vehicle. #Game

* [Ok that's really creepy, I don't wanna get envolved, I'll call the cops right now]-->BadEnding
* [This is terrible]-->LineOnePt4Resp1
* [...]-->LineOnePt4Resp2
* [I don't know what to say]-->LineOnePt4Resp3

== LineOnePt4Resp1 == 
- Why do you think that? I'm not gona hurt anyone... at least that's not the plan #Game

* [Can we change the subject?]-->LineOnePt5Resp1
* [I'm calling the cops]-->BadEnding

== LineOnePt4Resp2 == 
- Are you going to say something? #Game

* [Can we change the subject?]-->LineOnePt5Resp1
* [I'm calling the cops]-->BadEnding

== LineOnePt5Resp1 ==
- Yes, we can, so, what do you wanna talk about? #Game
* [Do you think hotdog is a sanduiche?]-->LineOnePt6Resp1
* [The cheese is expensive, isn't it?]-->LineOnePt6Resp2
* [Do you think is gonna rain today?]-->LineOnePt6Resp3

== LineOnePt6Resp1 == 
- I think so... what do you think? #Game

* [Of course it is]-->GoodEnding
* [Of course it is not]-->BadEnding

== LineOnePt6Resp2 == 
- YES, IT IS. I think I'm gonna have to rob a bank to buy some

* [Fine, I'll help you]-->GoodEnding
* [That's enough, you will think in something]-->UWillThinkSomething

== LineOnePt6Resp3 == 
- Looks like we got in a curious debate... You see, we can confirm that, or is raining, or isn'TURNS_SINCE

* [Finally someone that thinks the same way I do]-->GoodEnding
* [Man you need medication]-->BadEnding

== LineOnePt4Resp3 == 
- You don't have to say anything, I just needed to talk to someone... #Game
 -->WhatDoIDo

== LineOnePt3Resp2 ==
* [I'm gonna have to call the cops!] -->BadEnding
* [Actually, that is not my problem, it is a free country after all. Do you have a plan?] -->LineOnePt3Resp1


== LineOnePt2Resp2 ==
- I'm in deep debt... I mortgaged my house and sold every damn thing I could. My wife left me, I can't get a loan, let alone a job. That's the only option I have left. #Game

* [I got you, you are in a desperate situation so... do you have a plan?] -->LineOnePt3Resp1
* [Are you sure this is your only option?] -->LineOneNewPt

== LineOneNewPt ==
- Absolutely. Nothing can convince me not to do it. #Game

* [Tell me more] -->LineOnePt3Resp1
* [I can't agree with you, I'm sure you will think in something] -->UWillThinkSomething
* [Can you leave, please?] -->WhatDoIDo


== LineTwoPt1 ==
- How are you doing? #Game

* [Everything is going to hell... what about you?] -->LineOnePt1
* [Nothing much... just living another day] -->LineTwoPt2Resp1
* [Everything is great! I love pass time watching the clouds in the sky]-->LineTwoPt2Resp2

== LineTwoPt2Resp1 ==
- Yeah, I feel you...
-> LineOnePt1

== LineTwoPt2Resp2 ==
- At least someone is doing good... look... can we talk?

* [Yes, we can]
* [I don't know.]
* [...] 

- I'm thinking about robbing a bank. #Game 
-->LetTheGameBegin

-> END
