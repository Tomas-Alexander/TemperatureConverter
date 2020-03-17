# Temperature Converter
This is aan app that converts temperatures form one scale to another

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

For the use of this program is necessary to have installed the **.NET Core 2.1 Runtime** version, if it is not installed, go to this [page](https://dotnet.microsoft.com/download).

### Installing

First is necessary download this project or clone it using git.
```
git clone https://github.com/Tomas-Alexander/TemperatureConverter.git
```

If you don't have git installed, you can intalled it [here](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git).

### How to use
Open the command line, and go to the proyect folder where you downloaded it.

```
cd <your-project-path>/TemperatureConverter
```

And run it using

```
dotnet run
```

The first thing that the program does is ask the path of the file with the information to be converted

File format (data.txt): 
```
value,original-scale,wanted-scale
```

Then it will request a path *"path + filename.txt"* that will create a new file with the data processed.

File format (result.txt): 
```
value,original-scale,wanted-scale,result
```

### Example

1. Create a Test.txt:
```
0,C,F
```

2. Run the program
3. The program request the data file:
```
File path (read data): <path>/Test.txt
```

4. The program request the path of the result file:
```
File path (write data result): <path>/Result.txt
```

5. The program will process the data.
6. The result will be:
```
0,C,F,32
```

## Contributing

Please read [CONTRIBUTING.md](https://github.com/Tomas-Alexander/TemperatureConverter/blob/master/CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.


## License

This project is licensed under the MIT License - see the [LICENSE](https://github.com/Tomas-Alexander/TemperatureConverter/blob/master/LICENSE) file for details

