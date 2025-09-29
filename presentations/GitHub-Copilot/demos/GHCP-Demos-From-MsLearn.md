# GitHub Copilot Demos from Microsoft Learn

Source:

https://github.com/microsoft/Mastering-GitHub-Copilot-for-Paired-Programming/

## Getting Started With GitHub Copilot


### Step 1

Verify extension: Python, Copilot

GHCP Ask mode

```
@workspace Please briefly explain the structure of this project.
What should I do to run it?
```

Run it!

Run in Debug sidebar
Demo registration

Hey copilot, how can I create and publish a new Git branch called "accelerate-with-copilot"?

### Step 2

Show double registration

GHCP Ask mode

```
@workspace Students are able to register twice for an activity.
Where could this bug be coming from?
```
(click on method. File opens at method)

Add comment above method:

```
# Validate student is not already signed up
```


Inline chat

Select line 23 in app.py:
CTRL+I
Add 2 more sports related activities, 2 more artistic
activities, and 2 more intellectual activities.

Source Control tab
Click icon above Commit. Message generated

### Step 3

Edit Mode

	Key features
		Multi-file Editing: Copilot Edits can make changes across multiple files in your workspace.
		Iterative Workflow: Designed for fast iteration, allowing you to review, accept, or discard AI-generated code.
		In-place Edits: Shows generated code directly in your editor, providing a code review-like flow.
		Working Set: Allows you to define which files the edits should be applied to.
	How it works
		Set Context: Select files to be in the working set.
		Provide Instructions: Use natural language to describe the required changes.
		Review Changes: See proposed changes in-place in your code.
		Accept or Discard: Review each suggested edit and choose which to keep.
		Iterate: If needed, provide follow-up instructions to refine the changes.

Drag files to chat:
	src/static/app.js
	src/static/index.html
	src/static/styles.css

```
Hey Copilot, can you please edit the activity cards to add a participants section.
It will show what participants that are already signed up for that activity as a bulleted list.
Remember to make it pretty!
```

ProfessorCat: Agent created by GitHub Action

Hey @professortocat, Agent mode sounds pretty cool. Can you please tell me more about it?

## Using GitHub Copilot with JavaScript

https://github.com/microsoft/Mastering-GitHub-Copilot-for-Paired-Programming/tree/main/Using-GitHub-Copilot-with-JavaScript

### Section 1: Exploring your project

Open Chat

/help
/doc
/explain

Section 2: Code completion
src/routes.js

Above last line:

```
// Get a random recipe
```

Highlight:

```
router.get('/recipes', async (req, res) => {
	const db = await getDbConnection()
	const recipes = await db.all('SELECT * FROM recipes')
	res.render('recipes', { recipes })
})
```

CTRL+I
```
	Sort by title
```

### Section 3: Agent modeChat

Agent Mode
```
Implement the ability to delete recipes. Implement this using a HTML form and a new POST /recipes/:id/delete route handler. Make sure the buttons exist on both the recipe view and edit pages. Write  tests for your work.
```

### Section 4: Customization & context

Create .github/copilot-instructions.md

```
# GitHub Copilot Instructions

## Project Overview
This is a CRUD recipe application built with Node.js, Express, and Handlebars templating engine. The app allows users to create, read, update, and delete recipes with ingredients and cooking methods.

## Technology Stack
- **Backend**: Node.js with Express.js
- **Database**: SQLite with custom database layer
- **Templating**: Handlebars.js
- **Testing**: Jest
- **Styling**: Vanilla CSS

## Code Style Guidelines
- Use ES6+ features and async/await for asynchronous operations
- Follow RESTful routing conventions for recipe operations
- Use semantic HTML and BEM-style CSS classes where appropriate
- Keep database queries in the `src/database/` directory
- Store all view templates in the `views/` directory with Handlebars syntax

## Key Patterns
- Database operations should use the custom connection layer in `src/database/`
- Routes are defined in `src/routes.js` following Express patterns
- Handlebars helpers for text formatting (split, newline, add) are available
- Use proper error handling for database operations and route handlers
- Follow the existing form structure for CRUD operations

## Testing
- Test files are in `__tests__/` directory
- Use Jest for unit and integration testing
- Include tests for both database operations and route handlers
- Mock database connections in tests using the test setup files
```

Create .github/intructions/styling.instructions.md
```
---
applyTo: "public/*.css"
---

- Use semantic class names (`.recipe-*`, `.btn-*`, `.form-*`)
- Follow BEM methodology where appropriate
- Use consistent spacing units (8px, 16px, 24px)
- Use CSS custom properties for colors
- Mobile-first responsive design
- Use flexbox for layouts
- Ensure accessibility with proper contrast and focus states
- Ensure buttons have adequate touch targets (44px minimum)

Chat | Agent or Edit Mode
---
Create a new view to display FAQs
```

##  Integrate MCP with Copilot

### Step 1: Introduction to MCP and environment setup

Define Model Context Protocol (MCP)
"USB-C for AI" - universal connector for AI apps (e.g., GitHub Copilot) to interact with services.
In this demo, we interact with an existing MPC server running on GitHub

"Extensions" tab
	Search for "GitHub Copilot" and "Python"

Run app

Create ./vscode/msp.json

```
{
  "servers": {
    "github": {
      "type": "http",
      "url": "https://api.githubcopilot.com/mcp/"
    }
  }
}
```

Click [Start] inside mcp.json file

GitHub Copilot Chat

- Select Agent Mode
- Click "tools" icon in GHCP Chat window
	- Show all capabilities are checked

### Step 2: Agent Mode and an MCP Server for GitHub

Copilot Chat
Agent Mode

```
Search for any other repositories for organizing extra curricular activities
```

```
Please look at the code for the 3rd option and give me a detailed description of the features.
```

```
Please compare these features to our project. Which would be new?
```

```
I like it. Let's create issues for these in my repository.
```

### Step 3: Solve issues with Agent Mode and GitHub MCP Server

```
How many open issues are there on my repository?
```

```
Oh no. That's too many for me! Please get the list of issues,
review the descriptions and comments, and pick the top 3 most important.
```

```
#codebase Let's do the first one. Follow these steps:
1. Checkout a new local branch for making our changes.
2. Make the changes then confirm with me that they look correct.
3. Push the changes and start a pull request.
```

Source Control tab
- Add files
- Commit
- Push
- Create Pull Request

### Step 4: Validating AI-generated code

```
Add a closing comment to the issue we just finished. Provide a 1 sentence description
of the implemented solution and thank the commenters for their ideas and feedback.
```
