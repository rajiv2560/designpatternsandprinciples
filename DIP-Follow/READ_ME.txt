-	When we design software applications we can consider the low level classes (the classes which implement basic and primary operation 
	- disk access, network protocols....) and high level classes (the classes which encapsulate complex logic - business flows, ...).
	
	If the last ones rely on the low level classes, a natural way of implementing such structures sould be to write low level classes and once we have them,
	write the complex high level classes. Since since high level classes are defined in terms of others, this seems to be the logical way to do it. But
	this is not a flexible design. What happens if we need to replace a low level class?????

-	Let's take the classical example of a copy module which reads characters from the keyboard and writes them to the printer device. The high level class
	containing the logic is "Copy" class. (Let's assum that it is a very complex class, with a lot of logic and really hard to test.)
-	Bad Design:
	The high level class uses directly and depends heavily on the low level classes. In such a case if we want to change the design to direct
	the output to a new FileWriter class we have to make changes in the Copy class.
	(Let's assume that it is a very complex class, with a lot of logic and really hard to test).

-	To avoid this, we can introduce an abstraction layer between high level classes and low level classes. Since the high level modules
	contain the complex logic they should not depend on the low level modules so the new abstraction layer should not be created based on low level modules. 
	Low level modules are to be created based on the abstraction layer.

-	According to this principle the way of designing a class structure is to start from high level modules to the low level modules:
	High Level Classes --> Abstraction Layer --> Low Level Classes

-	Principle:
	-> High-level modules should not depend on low-level modules. Both should depend on abstractions.
	-> Abstractions should not depend on details. Details should depend on abstractions.
-	Example

	An example in "DIP-Violation", violates the Dependency Inversion Principle. We have the manager class which is a high level class, 
	and the low level class called Developer. We need to add a new module to our application to model the changes in the company structure determined by
	the employment of new specialized developers. We created a new class SuperDeveloper for this.

	Let's assume the Manager class is quite complex, containing very complex logic. And now we have to change it in order to introduce the new SuperDeveloper. 
	Let's see the disadvantages:
	we have to change the Manager class (remember it is a complex one and this will involve time and effort to make the changes).
	some of the current functionality from the manager class might be affected.
	the unit testing should be redone.
	All those problems could take a lot of time to be solved and they might induce new errors in the old functionlity. 

	==================================================================
	The situation would be different if the application had been designed following the Dependency Inversion Principle. 
	It means we design the Manager class, an IDeveloper interface and the Developer class implementing the IDeveloper interface. 
	When we need to add the SuperDeveloper class, all we have to do is, implement the IDeveloper interface for it. 
	No additional changes in the existing classes.