# Demos

## Setup

Create the chatbot in advance with the document uploaded. Document indexing takes a few minutes.

This video shows how:
https://youtu.be/5sWzkUTvNFU?si=PS0v4API984_5qDJ

Launch Copilot Studio in browser (https://aka.ms/copilotstudio)

[Create]

- A chatbot designed to support users in achieving their health and wellness goals. It provides personalized advice and resources across various aspects of health, including fitness, nutrition, and mental well-being.
- Change name
- Do not answer medical questions
- tone: Friendly
- Data Source: none
- [Create]

Show topics
		
		Conversation Start
		Greeting
		Start over
			Conditional
			Boolean
	System
		Fallback
			unknown topic
			retry 3 times
			call another topic
			
Knowledge
	Upload file (Healthy Eating Habits Q and A.docx)
	(Wait a few minutes to index)
	What are some tips for eating out healthily?
	
Channels
	Show options
	Show warning
	Change authentication | No Authentication
		[Settings} | Security | Authentication | No authentication
	Demo Website
        Copy URL
        Paste into browser
