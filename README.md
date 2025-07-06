# Partas.SolidStart

A set of templates to quickly get a SolidStart application rolling in F# Fable.

This is a great way to just get started with Partas.Solid and Solid-js and explore the SolidStart meta frame-work routing system et al.

To deploy this with a dotnet server, you would have to have more intimate knowledge of configuring SolidStart to plugin your own backend. To take the most advantage of SolidStart, you would likely move in the direction of having the solid-start backend communicate with your own backend.

> Uses the FAKE build process from the SAFE stack.

| Template Name      | Included libraries          | Description                                         |
|--------------------|-----------------------------|-----------------------------------------------------|
| bare-devtools      | solid-devtools              | Barebones template with devtools pre-setup          |
| tailwind-devtools  | tailwind v4; solid-devtools | Barebones template with tailwindcss v4 and devtools |
| solidbase-devtools | solidbase; solid-devtools   | SolidBase static website framework with devtools    |
| mdx-devtools       | solid-mdx; solid-devtools   | MDX based site template with devtools               |

> Solid-DevTools are a real boon that are automatically removed in production. You can disable them quite simply
> by removing the following from `entry-client.jsx`:
> ```jsx
> import 'solid-devtools';
>
> attachDevtoolsOverlay();
> ```


## Setup

1. Download the template via dotnet:

```
dotnet new install Partas.Solid.Start.Templates
```

2. Create a template using one of the provided options.
3. If you setup as a solution, you can delete the provided `Application.sln`, or copy some of the settings for organisation (it puts the solidstart related files in a solution folder).
4. Run the setup command from the root:

```
dotnet run setup
```

This will:
1. Install Fable tooling
2. Install Dotnet Packages
3. Install NPM Packages
4. Run the development server

> Installing the NPM Packages will take a while on the first run, be patient!

## Deployment

There is no premade setup for this, as there is just so many variables, and these templates would serve better as a member of a more complete, opinionated template. You can use the FAKE build system by modifying the `Build.fs` file to suit your needs.

Alternatively, you can just commit all `.fs.jsx` created in the dev process to a branch, and then deploy using Vercel or Netlify or whatever else is supported by Solid-Start from there.

This is in the scenario that you are not deploying with a dotnet server.

## Commands

1. Setup

See above.

```
dotnet run setup
```

2. Dev

Starts the development server.

```
dotnet run dev
```

3. Restore

Installs any missing dotnet/npm dependencies.

```
dotnet run restore
```
