# Can Copilot generate code that adhers to project/company standards?
This sample shows Copilot's ability to generate code that follows the standards of the project/company. Copilot is
trained on public code but it will also take into account other code opened in the IDE. That is, often times using the current version of Copilot will generate code that adhers to company standards and style. This effect can be demostrated by opening 'sample' files in the IDE.

## How to test this functionality
You can open up this project in codespaces for easy acess. Your job is to finish the code in the `StoreProxy.cs` file. The code added needs to adhere to the standards of the project as shown in the file `PetProxy.cs`. 
Look at the unfinish method `GetOrder`. Without having the 'PetProxy.cs' file open, Copilot will generate code that does not follow the standards of the project. 
Try adding the comment `// Handle ` or `// Handle the case where the response is not HTTP OK` as the last line of unfinished method. The code generated will not follow the standards of the project. 

Now open the file `PetProxy.cs`, check the error handling code and the logging. Go back and regenerate the code again, same test as before. As you can see, the standard and style of the project was picked up and affected the code generated. You can get Copilot to complete the rest of the method by adding newlines and waiting for Copilot to do it's job.

## Requirement picked up from tests
If you open up `TestStoreProxy.cs` you will see that there is a test for handeling negative values being passed in. Again, code generated will be different depending on if you have this test file opened or not. With the test file opened, try adding the comment `// Handle ne` or `// Handle negative values` in the top of the `GetOrder` method. You can see that Copilot was able to pick up the requirement from the test code and generate code that adhers to the requirement.
