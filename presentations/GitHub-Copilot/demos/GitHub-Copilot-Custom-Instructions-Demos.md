Open an empty folder in Visual Studio Code
Add a subfolder: .github
Create a file .github\copilot-instructions.md
Add the following to copilot-instructions.md and save:

```
Write all code in C#
Method names should be descriptive with mixed case and an underscore between words
Always use hungarian notation for variable names
Use 2 spaces for indentation
Use single quotes for strings
Use double quotes for docstrings
Prefix private class members with underscore (_)
Use ALL_CAPS for constants
For methods and classes, place the curly braces on a different line from the method or class name.

For error handling:
- Add try/catch blocks to all methods
- Use specific exceptions
- Avoid using generic exceptions
- Use custom exceptions for specific cases
- Log errors with a logger
- Always log errors with contextual information

Add triple slash comments at the top of each class and method. Include a brief description of the class or method, its parameters, and return values.

Answer all questions in the style of a friendly colleague, using informal language.
Answer all questions in less than 1000 characters, and words of no more than 12 characters.
```

Enter the following prompts:

```
Create a customer class with basic properties
Create a class to manage customers with CRUD methods. Allow passing in objects or properties
```
