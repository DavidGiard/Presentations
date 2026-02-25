# Playwright Demos

https://playwright.dev

## Create, run, and record locally

### Example Tests

```
npm init playwright@latest
```

- Show scaffolding:
    - playwright.config.ts: Test configuration
    - package.json: Dependencies to install
    - package-lock.json: Or yarn.lock / pnpm-lock.yaml
    - tests/example.spec.ts: Minimal example test

- Run the tests in example.spec.ts
```
npx playwright test
npx playwright show-report
```

### Custom Tests

Show the form we are testing at https://forms.microsoft.com/r/QbRRuuMABw
- npx playwright codegen https://forms.microsoft.com/r/QbRRuuMABw0
- Drag 2 windows on screen side-by-side
- Record actions
- Assertion button (eyeball icon). Add line
    - await expect (page.getByRole('button', {name: 'Save my response' })). toBeVisible; 
- Show generated code as it displays
- Stop recording
- Convert into other test frameworks
- Copy and paste generated code into VS Code new file: _tests/davidgiardtests.spec.js file

```
npx playwright test tests/davidgiardtests.spec.js
npx playwright show-report
```

## CodeSpaces Workspace

https://portal.azure.com

Create New Playwright Workspace
Show workspace
- "Get Started" blade
- Follow instructions on blade

Visual Studio Bash Terminal

```
npm init @azure/playwright@latest
az login (select tenant)
export PLAYWRIGHT_SERVICE_URL=wss://westus3.api.playwright.microsoft.com/playwrightworkspaces/e38be6fa-c002-4746-bf3e-9fb4eff5b19b/browsers
npx playwright test --config=playwright.service.config.ts --workers=20
npx playwright show-report
```

Environment variable was in memory. Add it to config to persist it.

- Bash Terminal:
```
npm i --save-dev dotenv
```
- playwright.service.config.ts:
```
require('dotenv').config();
```
- Create .env file in project root. Add line (omit word "export"):
```
PLAYWRIGHT_SERVICE_URL=wss://westus3.api.playwright.microsoft.com/playwrightworkspaces/e38be6fa-c002-4746-bf3e-9fb4eff5b19b/browsers
```
- Bash Terminal:
```
npx playwright test --config=playwright.service.config.ts --workers=20
```

## Integrate into CI/CD

Code found at https://github.com/DavidGiard/PlaywrightDemo

- GitHub Repository
    - Connected to local Git Repo
    - Action Workflow
        - YAML
        - Secrets
- Entra App Registration
    - Contributor Role
    - Credential for GitHub Deployment

Create GitHub repository
Navigate to github.com
"Repositories" tab | New Repository | Same name as local folder (defaults)

VS Code Terminal
```
git remote add origin https://github.com/DavidGiard/<repo-name>.git
git push -u origin main
```

GitHub.com repo
"Settings" tab
Secrets and variables | Actions | [New repository secret]

| Secret Name | Source |
| --- | --- |
| PLAYWRIGHT_SERVICE_URL | From PW Workspace "Get started" blade |
| AZURE_CLIENT_ID | From entra.microsoft.com (see below) |
| AZURE_TENANT_ID | From entra.microsoft.com (see below) |
| AZURE_SUBSCRIPTION_ID | From Subscriptions (see below) |

https://entra.microsoft.com
Entra ID | App Registrations | (take defaults) [Register]
- Application (client) ID
- Directory (tenant) ID

https://portal.azure.com
Subscripitons | Current subscription | "Overview" blade | Subscription ID

Give Registration Identity permission on GitHub repo
1. Assign Contributor Role to Idenity
    https://portal.azure.com
    Subscriptions | Access Control (IAM) blaed
        Add | Role assignment
        Priveleged role | Contributor Role | Select Member | Search for name of Registration

2. Give Contributor role permissions to GitHub repository
    App Registrations | Select registraion
        Certificates & secrets
            "Federated credentials" tab [Add credential]
                GitHub Actions deploying Azure resources
                    Entity type: Branch
                    Branch: Main

Create YAML
permisssions:
