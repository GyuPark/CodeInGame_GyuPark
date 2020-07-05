많은 복잡한 문제들은 이미 알려진 패턴으로 해결이 되었다.
컴퓨팅에는 디자인 패턴의 세 가지 범주가 있다.

1. 생성
2. 구조
3. 행위


생성 디자인 패턴은 객체가 생성되고 나중에 사용되는 방법과 관련되어 있다.
- Factory
- Prototype
- Singleton
- Builder

구조 디자인 패턴은 데이터와 함수가 구성되고 클래스에 배열되는 방법을 통합한다.
- Decorate
- Facade
- Flyweight ♪
- Adapter
- Proxy

동작 디자인 패턴은 시스템에서 객체 간의 의사소통에 초점을 맞춘다.
- Iterator
- Mediator
- Observer
- Visitor



<Game Programming Pattern - Robert Nystrom>

A key goal of software architecture is to minimize the amount of knowledge you need 
to have in cranium before you can make progress.

Many patterns that make your code more flexible rely on virtual dispatch, interfaces, pointers, messages,
and other mechanisms that all have at least some runtime cost. There is a reason for this. A lot of 
software architecture is about making your program more flexible. That means encoding fewer assumptions in the program.

You use interfaces so that your code works with any class that implements it instead of just the one that does today.
You use observers and messaging to let two parts of the game talk to each other so that tomorrow, it can easily be three or four.

But performance is all about assumptions. The practice of optimization thrives on concrete limitations.
게임이 가진 한계에 대해서 명확히 알 때, 우리는 최선의 최적화 작전을 수립할 수 있다. 

Making your program more flexible so you can prototype faster will have some performance cost.
Likewise, optimizing your code will make it less flexible. 
But note that from my personal experience, it's easier to make a fun game fast than it is to make a fast game fun.
One compromise is to keep the code flexible until the design settles down and then tear out some of the abstraction later to improve your performance.




1. Abstraction and decoupling make evolving your program faster and easier, but don't waste time doing them
unless you're confident the code in question needs that flexibility.
2. Think about and design for performance throughout your development cycle, but put off the low-level,
nitty-gritty optimizations that lock assumptions into your code until as late as possible.
3. Move quickly to explore your game's design space, but don't go so fast that you leave a mess behind you.
4. If you are going to ditch code, don't waste time making it pretty. 
5. If you want to make something fun, have fun making it.





[Command]
Commands are object oriented replacement for callbacks.

Somewhere in every game is a chunk of code that reads in raw user input.
It takes each input and translates it to a meaningful action in the game.
Instead of hard-wiring certain user inputs to game actions, 
allow users to configure how their buttons are mapped, by using "Command Pattern".





[Flyweight]

Anyone can describe a sprawling woodland with just a few sentences, 
but actually implementing it in realtime game is another story.
Even if you have enough memory to describe that forest, in order to render it,
that data has to make its way over the bus from the CPU to the GPU.

class Tree
{
private:
  Mesh mesh_;
  Texture bark_;
  Texture leaves_;
  Vector position_;
  double height_;
  double thickness_;
  Color barkTint_;
  Color leafTint_;
};

Each tree has a bunch of bits associated with it.
An entire forest of these objects is too much to throw at the GPU in one frame.
There's a time-honoured trick to handling this.
You will likely use the same mesh and textures for a lot of trees.
That means most of the fields in these objects are the same between all of those instances.

First, we pull out the data that all trees have in common and move it into a separate class.
class TreeModel
{
private:
  Mesh mesh_;
  Texture bark_;
  Texture leaves_;
};

Now, each instance of a tree in the world has a reference to that shared TreeModel.
What remains in Tree is the state that is intance-specific : 
class Tree
{
private:
  TreeModel* model_;

  Vector position_;
  double height_;
  double thickness_;
  Color barkTint_;
  Color leafTint_;
};

This is all well and good for storing stuff in main memory, but that doesn't help rendering. 
Before the forest gets on screen, it has to work its way over to the GPU.
We need to express this resource sharing in a way that GPU understands.

Fortunately, today's graphics API and cards support exactly this. Both Direct3D and OpenGl can do "instanced rendering".
This has to do with providing two streams of data, first being the blob of common data that will be rendered multiple times 
and the latter being the list of instsances and their parameters that will be used to vary that first chunk of data.
The fact that this API is implemented directly by the graphics card means the Flyweight pattern may be the only GoF design pattern to have actual hardware support.
