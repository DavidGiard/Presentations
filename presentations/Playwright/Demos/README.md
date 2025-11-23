# Playwright Demos

## Create, run, and record locally

npm init playwright@latest
Show scaffolding:

- playwright.config.ts: Test configuration
- package.json: Dependencies to install
- package-lock.json: Or yarn.lock / pnpm-lock.yaml
- tests/example.spec.ts: Minimal example test

npx playwright codegen https://forms.microsoft.com/r/QbRRuuMABw

- Drag 2 windows on screen side-by-side
- Record actions
- Assertion buttons
- Stop recording
- Show generated code
- Copy and paste generated code into VS Code new file: _tests/davidgiardtests.spec.js file

```
npx playwright test tests/davidgiardtests.spec.js
npx playwright show-report
```

## CodeSpaces Workspace

https://portal.azure.com

Create New Playwright Workspace
Show gcastpw
- "Get Started" blade

Visual Studio Terminal

```
npm init @azure/playwright@latest
az login (select tenantt 41)
export PLAYWRIGHT_SERVICE_URL=wss://westus3.api.playwright.microsoft.com/playwrightworkspaces/e38be6fa-c002-4746-bf3e-9fb4eff5b19b/browsers
npx playwright test --config=playwright.service.config.ts --workers=20
npx playwright show-report
```

## Integrate into CI/CD

- GitHub Repository
    - Connected to local Git Rep
    - Action Workflow
        - YAML
        - Secrets
- Entra App Registration
    - Contributor Role
    - Credential for GitHub Deployment
