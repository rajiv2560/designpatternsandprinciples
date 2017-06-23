
-	Software entities should be opened for extension, but closed for modification.
-	Once a class is done. it id done. (unless there is a bug on it)
-	Once a class has been written, it should not allow anyone to make changes. 
	No one should be able to go back and amend the class code in order to implement new functionalities.
-	Classes shouldn't allow for modification, but they can be extendable.

-	If the requirement changes, we do not modify the same class. We create a new class by inheriting the old/existing class and modification in the new class.
	And then start testing the new class.
-	If we make changes in the old class, then it needs to be re-tested with new unit tests.

- 	The Open-Closed Principle states that modules should be open for extension but closed for modification. Simply stated, 
	this means that we should not have to change our code every time a requirement or a rule changes. Our code should be extensible enough that we can write it 
	once and not have to change it later just because we have new functionality or a change to a requirement.

-	"Open for extension" means, we need to desing our module/class in such a way that the new functionality can be added only when new requirements are generated.
-	"Closed for modification" meeans, we have already developed a class and it has gone through unit testing. We should then not alter it until we find bugs.

-	Summary: Once the features or requirements change, it's a new class.