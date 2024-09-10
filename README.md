
# Extendio

**Extendio** est une bibliothèque d'extensions pour .NET qui améliore votre expérience de développement en fournissant des méthodes pratiques pour manipuler des chaînes de caractères, des collections et d'autres types de données. Avec Extendio, vous bénéficiez de solutions élégantes et efficaces pour des problèmes courants de manipulation de données.

## Fonctionnalités

- **Troncature Avancée** : Tronquez les chaînes à une longueur spécifiée ou à un nombre de mots, avec ajout automatique de points de suspension.
- **Formatage Dynamique** : Appliquez des formats personnalisés aux chaînes de caractères.
- **Validation de Données** : Vérifiez et validez les données d'entrée.
- **Opérations sur les Collections** : Simplifiez les opérations courantes sur les collections telles que les listes et les tableaux.

## Installation

Vous pouvez installer Extendio via NuGet. Utilisez l'une des méthodes suivantes pour ajouter Extendio à votre projet :

### Via NuGet Package Manager Console

```sh
Install-Package Extendio
```
### Via .Net CLI
```sh
dotnet add package Extendio
```
## Utilisation
### Troncature de Chaînes
#### Troncature par Longueur
```
using Extendio;

string longString = "This is a very long string that needs to be truncated.";
string truncatedString = longString.Truncate(20);
// Résultat : "This is a very long..."

```
## Contributing

Contributions are what make the open-source community such an amazing place to be, learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request


## License

Distributed under the MIT License.
