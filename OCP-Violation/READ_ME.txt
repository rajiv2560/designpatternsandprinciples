-	This code is not following OCP.
-	ValidateData is open for new additions or operations and if we want to extend it, 
	that will be a tedious job.
-	Let’s think of a scenario in which we want to extend this class so that it can use another
	external service. In such a scenario, as developers we would have no choice but to modify 
	the IsValid method. Also, if the class must be made a component and provided to third parties for 
	use, these third-party users would have no way to add another service, and that would mean this 
	class is not open for extensions. Also, if we need to modify the behavior in order to persist data, 
	we would need to change the actual class.To sum up, this class is directly violating OCP 
	because it is neither open for extensions nor closed for modifications.