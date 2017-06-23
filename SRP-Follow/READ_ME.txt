-   A class should have only one responsibility. Let’s say our class is 
	responsible for saving data. That means it should not also be 
	responsible for retrieving data or any other tasks.

-	Class has single responsibility + Class has only one reason to change => Single Responsibility Principle.
-	This means that every class or similar structure, in code should have only one job to do. Everything in that class should be related to a single purpose.
	

Implementation for SRP:

	1. Contact external servers
	2. Sync/fetch data
	3. Analyze/scan data
	4. Store in temporary storage
	5. Save/persist database on local server(s)

