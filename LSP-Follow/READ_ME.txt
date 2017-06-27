-	If S is a subtype of T, then objects of type T may be replaced with objects of type S (i.e. objects of type S may substitute objects of type T)
	without altering any of the desirable properties of that program.
-	This means, a subclass should behave in such a way that it will not cause problems when used instead of the superclass.
-	Liskov Substitution Principle:
	The object of a derived class should be able to replace an object of the base class without bringg any errors in the system or modifying the behavior of the 
	base class.
-	In short:
	If S is subset of T, an object of T could be replaced by object of S without impact the program and bringing any error in the system.
	
	Let's say we have a class "Rectangle" and another class "Square". 
	Square is a Rectangle, or in other words, it inherits the Rectangle class. So as Liskov Substitution Principle states, we should be able to replace object of Rectangle
	by the object of Square without bringing any undesirable change or error in the system.
