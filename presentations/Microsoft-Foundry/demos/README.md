# Microsoft Foundry Demo

The goal of this demo is to show three things quickly:

1.  **How simple it is to create an agent**
2.  **How Instructions shape agent behavior**
3.  **How this becomes a reusable developer capability**

***

# 10‑Minute Demo: Building an AI Agent in Azure AI Foundry

## 0:00 – 1:00 | Set the Context

**Say:**

> “Many partners ask us how they go from experimenting with prompts to building real AI assistants or agents inside applications.  
> Azure AI Foundry provides a place to design, ground, and test those agents.  
> I’ll build one in a couple minutes so you can see how it works.”

Briefly point to the screen.

**Call out:**

*   This is **Azure AI Foundry**
*   We can **design agents, add instructions, attach knowledge, and test them**

> “Instead of coding everything from scratch, we start by defining the *behavior* of the agent.”

***

# 1:00 – 2:30 | Explain the Instructions Field

Point to the **Instructions** section where you pasted the prompt.

**Say:**

> “The most important step is defining the **Instructions**.  
> Think of this as the agent’s operating manual.”

Highlight the key ideas in your prompt.

Example:

*   It defines **the persona**
*   It defines **what topics the agent knows**
*   It defines **how answers should be structured**

**Example explanation:**

	You are an AI assistant that helps software developers learn Microsoft AI and data technologies.
	
	Your role is to:
	- Explain concepts clearly and concisely.
	- Provide step-by-step guidance when someone asks “how do I do this?”
	- When appropriate, show short code examples (C#, Python, or JavaScript).
	- Ask clarifying questions if the user’s request is ambiguous.
	- Summarize key ideas in bullet points so they are easy to remember.
	
	Focus especially on:
	- Azure AI Foundry
	- Azure OpenAI
	- GitHub Copilot
	- Building AI agents and copilots
	- Best practices for security, governance, and responsible AI
	
	When responding:
	1. Start with a short, clear answer.
	2. Follow with a structured explanation or steps.
	3. Include practical tips or common pitfalls.
	4. Keep the tone friendly and professional, like a helpful technical mentor.
	
	If a user asks about something unrelated to technology, politely steer the conversation back to AI, software development, or Microsoft cloud tools.

**Key takeaway to speak out loud:**

> “So instead of fine‑tuning models, we steer behavior with instructions.”

***

# 2:30 – 3:30 | Create the Agent

Scroll down.

Click **Create** or **Save Agent**.

**Narration:**

> “Once the instructions and model are configured, we create the agent.  
> Foundry handles the infrastructure and gives us a testing environment.”

Short pause while it loads.

***

# 3:30 – 6:00 | Demo the Agent in Chat

Open the **Test Chat** panel.

Say:

> “Now let’s interact with our agent.”

### Prompt #1 — Basic Explanation

Type:

    Explain what Azure AI Foundry agents are and how they help developers. 

Expect a structured response.

**Call out:**

> “Notice the response style:
>
> *   short explanation
> *   structured steps
> *   developer‑focused language”

***

### Prompt #2 — Practical Scenario

Type:

    Show me how a developer could build an AI agent for customer support using Azure AI Foundry.

**Talking point:**

> “Now it’s acting like a **technical coach**, breaking the task into steps.”

Highlight:

*   Architecture thinking
*   Guidance
*   Developer framing

***

### Prompt #3 — Code Request (Always impresses audiences)

Type:

    Show me a simple Python example of calling an Azure AI Foundry agent from an app.

Tell audience:

> “Because we framed this as a developer mentor, it often includes example code or implementation steps.”

Pause briefly while audience scans.

***

# 6:00 – 7:30 | Show the Real Power: Prompt Steering

Now edit the Instructions quickly.

Add a line at the bottom:

    Always end answers with a short numbered checklist called "Next Steps".

Save.

Return to Test Chat.

Ask again:

    I want to build my first Azure AI Foundry agent. What steps should I take?

**Point out:**

> “Now our agent finishes with **Next Steps** because we changed the instructions.”

Key line to say:

> “So the behavior of the AI isn’t magic — it’s **designed**.”

***

# 7:30 – 9:00 | Connect It to Real Applications

Shift the focus to value.

**Explain:**

> “This test interface is just for development.  
> In real projects, developers connect this agent to applications.”

Examples developers use:

*   Internal copilot tools
*   Developer assistants
*   Customer support automation
*   Knowledge assistants
*   AI capabilities inside SaaS apps

You can mention:

> “The same agent can power a web app, Teams bot, or enterprise workflow.”

(That resonates well with partner architects.)

***

# 9:00 – 10:00 | Strong Closing

End with something memorable.

**Suggested closing:**

> “So in less than 10 minutes we:
>
> *   Created an AI agent
> *   Defined its personality and expertise
> *   Tested it live
> *   And adjusted its behavior through instructions.
>
> For developers and partners, Azure AI Foundry becomes the **design center for intelligent applications**.”

Optional **final punch line**:

> “Instead of hard‑coding AI behavior, we design it.”

***

# Bonus: 3 Backup Prompts (if demo goes fast)

These tend to get good reactions.

**Prompt 1**

    Create a quick learning plan for a developer who wants to become productive with Azure AI Foundry.

**Prompt 2**

    What are common mistakes teams make when building their first AI agent?

**Prompt 3**

    Compare Azure AI Foundry agents with a traditional REST API service.

***

✅ **Tip for you specifically (since you often present to partner architects):**

If the audience is technical, add this question at the end:

    What architecture components are typically involved in a production AI agent solution on Azure?

It produces a nice **architecture-style answer**, which aligns well with your **Partner Solution Architect** role.

***

If you'd like, I can also show you **a 5‑minute “conference/executive” version of this same demo** that works extremely well in settings like **AI Tour or NDC**, where you need a faster, higher‑impact story.
