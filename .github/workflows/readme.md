# Workflow for github actions

name: Run Azure Login with OIDC
    - on push it logs into azure

GitHub Actions can only read a secret if you explicitly include the secret in a workflow.

## Login With OpenID Connect (OIDC) [Recommended]
    secrets saved in github actions/secrets
        AZURE_CLIENT_ID
        AZURE_TENANT_ID
        AZURE_SUBSCRIPTION_ID

## Login With a Service Principal Secret

Before you login a service principal secret, you need to prepare a service principal with a secret.
    
    - Create a service principal and assign a role to it
    - Create a new service principal client secret
    
    AZURE_CREDENTIALS
        "clientSecret":  "******",
        "subscriptionId":  "******",
        "tenantId":  "******",
        "clientId":  "******"