# NBJ Academy — Brazilian Jiu Jitsu Website

The website is found here - [Nbjacademy](https://www.nbjacademy.com.au)

A modern, fast, and maintainable website built for NBJ Academy using Blazor WebAssembly on .NET 8. The site highlights the academy’s culture, classes, and schedule while delivering a clean, responsive experience across devices.

## Live Experience

- Fast client-side navigation and smooth page transitions
- Mobile-first layout with responsive components
- Optimized loading with progressive bootstrapping and dynamic styling
- Engaging visuals (hero sections, carousel, gallery) with subtle motion via parallax

## Tech Stack

- .NET 8 + Blazor WebAssembly: SPA architecture without JavaScript frameworks, compiled C# running in the browser via WebAssembly.
- Bootstrap 5 (bundle via CDN) for responsive grid, utilities, and UI patterns.
- Custom CSS per page and component for scoped styling:
  - `Home.razor.css`, `AboutUs.razor.css`, `Gallery.razor.css`, `SiteHeader.razor.css`, `Carousel.razor.css`
- Google Fonts: Inter and Montserrat for a modern, athletic aesthetic.
- Progressive loading shell (`wwwroot/index.html`) with a spinner and text placeholder.
- Lightweight JS enhancements:
  - `javascript/parallax.js` for subtle scroll-based motion
  - `javascript/resize.js` for responsive adjustments
- Deployment-ready for static hosting and CDNs; includes `staticwebapp.config.json` for route and asset handling (Azure Static Web Apps compatible).

## Key Pages & Components

- `Pages/Home.razor` — Hero, intro, highlights, call-to-action.
- `Pages/AboutUs.razor` — Academy values, coaching philosophy, community focus.
- `Pages/Timetable.razor` — Clear weekly schedule with responsive layout.
- `Pages/Gallery.razor` — Visual showcase with performant image loading.
- `Pages/FindUs.razor` — Location, access, and contact information.
- `Pages/ContactUs.razor` — Contact form and direct reach options.
- `Components/SiteHeader.razor` — Clean, persistent navigation across the app.
- `Components/Carousel.razor` — Visual slider for promotions or featured content.

## Design Decisions

- Blazor WebAssembly on .NET 8
  - Single codebase in C# for UI and logic.
  - Fast client-side UX with serverless-friendly deployment.
- Accessibility & SEO
  - Semantic HTML, descriptive metadata, and Open Graph tags for better sharing.
  - Mobile-friendly viewport configuration and sensible contrast choices.
- Performance
  - CDN-loaded Bootstrap bundle for quick startup.
  - Scoped CSS reduces bloat and prevents side effects.
  - Loading shell shows immediate feedback while the app initializes.
- Maintainability
  - Component-based architecture (header, carousel, sections).
  - Page-specific styles keep changes localized.
  - Clean separation of assets under `wwwroot`.

## Getting Started

Prerequisites:
- .NET 8 SDK
- Visual Studio with Blazor support

Run locally:
