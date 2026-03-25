---
description: General project guidelines for the University of Amsterdam GitHub Copilot customization exercise. Apply when editing step files, instructions, prompts, agents, or any markdown in this repository.
applyTo: "**/*.md"
---

## Project Context

This repository is a GitHub Skills exercise teaching developers and educators how to customize GitHub Copilot using:
- Repository-wide custom instructions (`.github/copilot-instructions.md`)
- File-scoped instructions (`.github/instructions/*.instructions.md`)
- Reusable prompt files (`.github/prompts/*.prompt.md`)
- Custom agents (`.github/agents/*.agent.md`)

## Coding & Content Guidelines

- Keep all markdown concise and instructional — this is a learning exercise, not documentation.
- Follow existing step file formatting conventions (numbered lists, `> [!TIP]` callouts, `<details>` blocks).
- Assignment starter code should be written in Python and follow PEP 8.
- Never generate complete assignment solutions — only scaffolding and starter code.

## Image References

Always use absolute GitHub raw URLs when referencing images in markdown files. Never use relative paths (e.g. `../../assets/images/`), as they break in VS Code preview and GitHub Skills workflow contexts.

**Pattern:**
```
https://raw.githubusercontent.com/mburakunuvar/ghcp-lab02-customize-your-github-copilot-experience/main/assets/images/<filename>
```

**Example:**
```markdown
<img width="600" alt="description" src="https://raw.githubusercontent.com/mburakunuvar/ghcp-lab02-customize-your-github-copilot-experience/main/assets/images/example.png" />
```
