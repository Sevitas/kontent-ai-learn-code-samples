// DocSection: cm_api_v2_get_taxonomy_groups
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

// Gets the first page of results
const response = await client.listTaxonomies()
  .toPromise();

// Gets all pages of results
// const response = await client.listTaxonomies()
//   .toAllPromise();
// EndDocSection