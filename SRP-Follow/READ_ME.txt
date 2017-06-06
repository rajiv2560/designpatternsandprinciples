-   A class should have only one responsibility. Let’s say our class is 
	responsible for saving data. That means it should not also be 
	responsible for retrieving data or any other tasks.

Implementation for SRP:
	1. Contact external servers
	2. Sync/fetch data
	3. Analyze/scan data
	4. Store in temporary storage
	5. Save/persist database on local server(s)

