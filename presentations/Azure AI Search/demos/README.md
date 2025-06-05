# Azure AI Search Demos

## AI Search

### Prep

- Create an Azure OpenAI Service (45 second deployment)
- AI Foundry
    - Deployments | Base Model | text-embedding-ada-002
- Create an Azure Storage Account
    - Basics
        - Primary Service: blob storage
        - Performance: Standard
        - Locally Redundant Storage
    - Advanced
        - Allow enabling anonymous access on individual container
    - Create a blob container: "Reviews" (allow anonymous access)
    - Configure
        - IAM | Add yourself to "Storage Blob Data Contributor" role
        - Networking | Public Network Access | Enable
        - Settings | Configuration
            - Enable Blob Anonymous Access
            - Enable Storage Account Key Access

- Unzip [Coffee Shop Review files](./CoffeeShopReviews.zip) into a folder on your local machine.

### Demo

- Show reviews
    - Different types of files
    - Includes text, but no rating
    - Includes locations
- Upload Coffee Shop Review files int Reviews blob container
- Create Azure AI Search (10 seconds deployment)
    - Import data
    - Show indexer and index
    - Start Searching
        *
        search=locations:'Chicago'
        search=keyphrases:'delicious'
- Show Storage account
    - Show metadata created. This is what is searched.

## Azure AI Foundry

- Azure AI Foundry
    - "Chat" tab
        - Deployment | Base Model | gpt-4o
        - Settings | Add Data Source | AI Search

    - Query:
        - What are some good coffee shops in Chicago?
