This is a basic little practice project to get back in the swing of C#

TrueHitRandom is a subclass of random that generates results in the format of Fire Emblem's True Hit RNG
- tldr is you roll twice and return the average of both rolls, so the distribution will be biased towards results closer to 0.5 

GaussianRandom isn't a true gaussian/normal distribution in some technical sense, because I have bounded the results to stay within the RNG's [0,1) range of sample generation
- it can optionally take in inputs for the mean value and the standard deviation as doubles 
- I don't have any real protections for the range of doubles to accept, but if you don't keep them inside [0,1) you'll probably just end up with an output of entirely the min or max values of Random.